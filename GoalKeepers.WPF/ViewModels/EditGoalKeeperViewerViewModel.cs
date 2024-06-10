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
        public Guid GoalKeeperViewerId { get; }
        public GoalKeeperViewerDetailsFormViewModel GoalKeeperViewerDetailsFormViewModel { get; }

        public EditGoalKeeperViewerViewModel(GoalKeeperViewer goalKeeperViewer, GoalKeeperViewersStore goalKeeperViewersStore, ModalNavigationStore modalNavigationStore)
        {

            GoalKeeperViewerId= goalKeeperViewer.Id;

            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            ICommand submitCommand = new EditGoalKeeperViewerCommand(this, goalKeeperViewersStore, modalNavigationStore);
            GoalKeeperViewerDetailsFormViewModel = new GoalKeeperViewerDetailsFormViewModel(submitCommand, cancelCommand)
            {
                LastName = goalKeeperViewer.LastName,
                Crosses = goalKeeperViewer.Crosses,
                GoalLine = goalKeeperViewer.GoalLine,
            };
        }
    }
}
