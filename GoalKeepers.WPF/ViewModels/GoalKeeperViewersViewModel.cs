using GoalKeepers.WPF.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GoalKeepers.WPF.ViewModels
{
    public class GoalKeeperViewersViewModel : ViewModelBase
    {

        public GoalKeeperViewersListingViewModel ListingViewModel { get; }
        public GoalKeepersViwersDetailsViewModel DetailViewModel { get;}
        public ICommand AddGoalKeeperViewersCommand { get; }

        public GoalKeeperViewersViewModel(SelectedGoalKeeperViewerStore _selectedGoalKeeperStore)
        {
            ListingViewModel= new GoalKeeperViewersListingViewModel(_selectedGoalKeeperStore);
            DetailViewModel = new GoalKeepersViwersDetailsViewModel(_selectedGoalKeeperStore);
        }
    }
}
