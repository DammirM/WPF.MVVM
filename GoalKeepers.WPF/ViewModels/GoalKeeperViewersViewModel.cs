using GoalKeepers.WPF.Commands;
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

        public GoalKeeperViewersListingViewModel GoalKeeperViewersListingViewModel { get; }
        public GoalKeeperViewersDetailsViewModel GoalKeeperViewersDetailsViewModel { get;}
        public ICommand AddGoalKeeperViewersCommand { get; }

        public GoalKeeperViewersViewModel(SelectedGoalKeeperViewerStore _selectedGoalKeeperStore, ModalNavigationStore modalNavigationStore)
        {
            GoalKeeperViewersListingViewModel = new GoalKeeperViewersListingViewModel(_selectedGoalKeeperStore, modalNavigationStore);
            GoalKeeperViewersDetailsViewModel = new GoalKeeperViewersDetailsViewModel(_selectedGoalKeeperStore);

            AddGoalKeeperViewersCommand = new OpenAddGoalKeeperViewerCommand(modalNavigationStore);
        }
    }
}
