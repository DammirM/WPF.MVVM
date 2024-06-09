using GoalKeepers.WPF.Commands;
using GoalKeepers.WPF.Models;
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
        private readonly SelectedGoalKeeperViewerStore _selectedGoalKeeperViewerStore;

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

        public GoalKeeperViewersListingViewModel(SelectedGoalKeeperViewerStore selectedGoalKeeperViewerStore, ModalNavigationStore modalNavigationStore)
        {
            this._selectedGoalKeeperViewerStore = selectedGoalKeeperViewerStore;

            _goalKeeperViewersListingItemViewModel = new ObservableCollection<GoalKeeperViewersListingItemViewModel>();

            AddGoalKeeper(new GoalKeeperViewer("Courtois", true, false), modalNavigationStore);
            AddGoalKeeper(new GoalKeeperViewer("Allison", false, false), modalNavigationStore);
            AddGoalKeeper(new GoalKeeperViewer("Ter Stegen", true, true), modalNavigationStore);
        }

        private void AddGoalKeeper(GoalKeeperViewer goalKeeperViewer, ModalNavigationStore modalNavigationStore)
        {
            ICommand editCommand = new OpenEditGoalKeeperViewerCommand(goalKeeperViewer, modalNavigationStore);
            _goalKeeperViewersListingItemViewModel.Add(new GoalKeeperViewersListingItemViewModel(goalKeeperViewer, editCommand));

        }
    }
}
