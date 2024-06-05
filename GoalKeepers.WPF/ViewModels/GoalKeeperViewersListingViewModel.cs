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
        private readonly ObservableCollection<GoalKeeperViewersListingItemViewModel> _listingItem;
        public IEnumerable<GoalKeeperViewersListingItemViewModel> listingItem => _listingItem;

        private GoalKeeperViewersListingItemViewModel _selectedGoalKeeperViewerListingItemViewModel

            public GoalKeeperViewersListingViewModel SelectedGoalKeeperViewerListingItemViewModel
        {
            get
            {
                return _selectedGoalKeeperViewerListingItemViewModel;
            }
            set
            {
                _selectedGoalKeeperViewerListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedGoalKeeperViewerListingItemViewModel));
            }
        }

        public GoalKeeperViewersListingViewModel(SelectedGoalKeeperViewerStore _selectedGoalKeeperStore)
        {
            _listingItem = new ObservableCollection<GoalKeeperViewersListingItemViewModel>();

            _listingItem.Add(new GoalKeeperViewersListingItemViewModel("Dam"));
            _listingItem.Add(new GoalKeeperViewersListingItemViewModel("Nikki"));
            _listingItem.Add(new GoalKeeperViewersListingItemViewModel("Sid"));

        }
    }
}
