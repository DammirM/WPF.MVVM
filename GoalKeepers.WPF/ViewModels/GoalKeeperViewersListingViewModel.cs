using GoalKeepers.WPF.Models;
using GoalKeepers.WPF.Store;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public GoalKeeperViewersListingViewModel(SelectedGoalKeeperViewerStore selectedGoalKeeperViewerStore)
        {
            this._selectedGoalKeeperViewerStore = selectedGoalKeeperViewerStore;

            _goalKeeperViewersListingItemViewModel = new ObservableCollection<GoalKeeperViewersListingItemViewModel>();

            _goalKeeperViewersListingItemViewModel.Add(new GoalKeeperViewersListingItemViewModel(new GoalKeeperViewer("Courtois", true, false)));
            _goalKeeperViewersListingItemViewModel.Add(new GoalKeeperViewersListingItemViewModel(new GoalKeeperViewer("Allison", false, false)));
            _goalKeeperViewersListingItemViewModel.Add(new GoalKeeperViewersListingItemViewModel(new GoalKeeperViewer("Ter Stegen", true, true)));
        }
    }
}
