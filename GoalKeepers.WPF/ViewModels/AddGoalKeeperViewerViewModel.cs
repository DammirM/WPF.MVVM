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
    public class AddGoalKeeperViewerViewModel : ViewModelBase
    {

        public GoalKeeperViewerDetailsFormViewModel GoalKeeperViewerDetailsFormViewModel { get; }

        public AddGoalKeeperViewerViewModel(GoalKeeperViewersStore goalKeeperViewersStore, ModalNavigationStore modalNavigationStore)
        {
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            ICommand submitCommand = new AddGoalKeeperViewerCommand(this, goalKeeperViewersStore, modalNavigationStore);
            GoalKeeperViewerDetailsFormViewModel = new GoalKeeperViewerDetailsFormViewModel(submitCommand, cancelCommand);
        }
    }
}
