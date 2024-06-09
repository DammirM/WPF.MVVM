using GoalKeepers.WPF.Commands;
using GoalKeepers.WPF.Models;
using GoalKeepers.WPF.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GoalKeepers.WPF.ViewModels
{
    public class EditGoalKeeperViewerViewModel : ViewModelBase
    {

        public GoalKeeperViewerDetailsFormViewModel GoalKeeperViewerDetailsFormViewModel { get; }

        public EditGoalKeeperViewerViewModel(GoalKeeperViewer goalKeeperViewer, ModalNavigationStore modalNavigationStore)
        {
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            ICommand submitCommand = new EditGoalKeeperViewerCommand(modalNavigationStore);
            GoalKeeperViewerDetailsFormViewModel = new GoalKeeperViewerDetailsFormViewModel(submitCommand, cancelCommand)
            {
                LastName = goalKeeperViewer.LastName,
                Crosses = goalKeeperViewer.Crosses,
                GoalLine = goalKeeperViewer.GoalLine,
            };
        }
    }
}
