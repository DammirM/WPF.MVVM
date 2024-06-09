using GoalKeepers.WPF.Models;
using GoalKeepers.WPF.Store;
using GoalKeepers.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.WPF.Commands
{
    public class OpenEditGoalKeeperViewerCommand: CommandBase
    {
        private readonly GoalKeeperViewer _goalKeeperViewer;
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenEditGoalKeeperViewerCommand(GoalKeeperViewer goalKeeperViewer, ModalNavigationStore modalNavigationStore)
        {
            _goalKeeperViewer = goalKeeperViewer;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            EditGoalKeeperViewerViewModel editGoalKeeperViewerViewModel = new EditGoalKeeperViewerViewModel(_goalKeeperViewer, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editGoalKeeperViewerViewModel;
        }
    }
}
