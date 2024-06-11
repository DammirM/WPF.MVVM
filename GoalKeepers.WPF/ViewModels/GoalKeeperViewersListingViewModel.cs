using GoalKeepers.EntityFrameWork.Models;
using GoalKeepers.WPF.Commands;
using GoalKeepers.EntityFrameWork.Models;
using GoalKeepers.WPF.Store;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GoalKeepers.WPF.ViewModels
{
    public class GoalKeeperViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<GoalKeeperViewersListingItemViewModel> _goalKeeperViewersListingItemViewModel;
        private readonly GoalKeeperViewersStore _goalKeeperViewersStore;
        private readonly SelectedGoalKeeperViewerStore _selectedGoalKeeperViewerStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public IEnumerable<GoalKeeperViewersListingItemViewModel> GoalKeeperViewersListingItemViewModel => _goalKeeperViewersListingItemViewModel;

        private GoalKeeperViewersListingItemViewModel _selectedGoalKeeperViewerListingItemViewModel;

            public GoalKeeperViewersListingItemViewModel SelectedGoalKeeperViewerListingItemViewModel
        {
                get
                {
                    return _selectedGoalKeeperViewerListingItemViewModel;
                }
                set
                {
                    _selectedGoalKeeperViewerListingItemViewModel = value;
                    OnPropertyChanged(nameof(SelectedGoalKeeperViewerListingItemViewModel));

                _selectedGoalKeeperViewerStore.SelectedGoalKeeperViewer = _selectedGoalKeeperViewerListingItemViewModel?.GoalKeeperViewer;
                }
            }

        public ICommand LoadGoalKeepersCommand { get; }

        public GoalKeeperViewersListingViewModel(GoalKeeperViewersStore goalKeeperViewersStore, SelectedGoalKeeperViewerStore selectedGoalKeeperViewerStore, ModalNavigationStore modalNavigationStore)
        {
            _goalKeeperViewersStore = goalKeeperViewersStore;
            _selectedGoalKeeperViewerStore = selectedGoalKeeperViewerStore;
            _modalNavigationStore = modalNavigationStore;
            _goalKeeperViewersListingItemViewModel = new ObservableCollection<GoalKeeperViewersListingItemViewModel>();

            LoadGoalKeepersCommand = new LoadGoalKeeperViewersCommand(goalKeeperViewersStore);

            _goalKeeperViewersStore.GoalkeepersVirwersLoaded += GoalKeeperViewersStore_GoalkeepersVirwersLoaded;
            _goalKeeperViewersStore.GoalKeeperViewerAdded += GoalKeeperViewersStore_GoalKeeperViewerAdded;
            _goalKeeperViewersStore.GoalKeeperViewerUpdated += GoalKeeperViewersStore_GoalKeeperViewerUpdated;
            _goalKeeperViewersStore.GoalKeeperViewerDeleted += GoalKeeperViewersStore_GoalKeeperViewerDeleted;
        }

        private void GoalKeeperViewersStore_GoalKeeperViewerDeleted(Guid id)
        {
           var itemViewModel = _goalKeeperViewersListingItemViewModel.FirstOrDefault(g => g.GoalKeeperViewer?.Id == id);

            if (itemViewModel != null) 
            {
                _goalKeeperViewersListingItemViewModel.Remove(itemViewModel); 
            }
        }

        private void GoalKeeperViewersStore_GoalkeepersVirwersLoaded()
        {
           _goalKeeperViewersListingItemViewModel.Clear();

            foreach (GoalKeeperViewer goalKeeperViewer in _goalKeeperViewersStore.GoalKeeperViewers)
            {
                AddGoalKeeper(goalKeeperViewer);
            }
        }

        public static GoalKeeperViewersListingViewModel LoadViewModel(GoalKeeperViewersStore goalKeeperViewersStore, SelectedGoalKeeperViewerStore selectedGoalKeeperViewerStore, ModalNavigationStore modalNavigationStore)
        {
            GoalKeeperViewersListingViewModel viewModel = new GoalKeeperViewersListingViewModel(goalKeeperViewersStore, selectedGoalKeeperViewerStore, modalNavigationStore);

            viewModel.LoadGoalKeepersCommand.Execute(null);

            return viewModel;
        }
        private void GoalKeeperViewersStore_GoalKeeperViewerUpdated(GoalKeeperViewer goalKeeperViewer)
        {
            GoalKeeperViewersListingItemViewModel goalKeeperViewerViewModel =
                _goalKeeperViewersListingItemViewModel.FirstOrDefault(g => g.GoalKeeperViewer.Id == goalKeeperViewer.Id);

            if (goalKeeperViewerViewModel != null) 
            {
                goalKeeperViewerViewModel.Update(goalKeeperViewer);
            }
        }

        protected override void Dispose()
        {
            _goalKeeperViewersStore.GoalKeeperViewerAdded -= GoalKeeperViewersStore_GoalKeeperViewerAdded;
            _goalKeeperViewersStore.GoalKeeperViewerUpdated -= GoalKeeperViewersStore_GoalKeeperViewerUpdated;
            _goalKeeperViewersStore.GoalkeepersVirwersLoaded -= GoalKeeperViewersStore_GoalkeepersVirwersLoaded;
            _goalKeeperViewersStore.GoalKeeperViewerDeleted -= GoalKeeperViewersStore_GoalKeeperViewerDeleted;



            base.Dispose(); 
        }
        private void GoalKeeperViewersStore_GoalKeeperViewerAdded(GoalKeeperViewer goalKeeperViewer)
        {
            AddGoalKeeper(goalKeeperViewer);
        }

        private void AddGoalKeeper(GoalKeeperViewer goalKeeperViewer)
        {
            GoalKeeperViewersListingItemViewModel itemViewModel = new GoalKeeperViewersListingItemViewModel(goalKeeperViewer, _goalKeeperViewersStore, _modalNavigationStore);
            _goalKeeperViewersListingItemViewModel.Add(itemViewModel);

        }
    }
}
