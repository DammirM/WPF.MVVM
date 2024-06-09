using GoalKeepers.WPF.Store;
using GoalKeepers.WPF.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GoalKeepers.WPF.Commands
{
    public class OpenAddGoalKeeperViewerCommand : CommandBase
    {

        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenAddGoalKeeperViewerCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            AddGoalKeeperViewerViewModel addGoalKeeperViewerViewModel = new AddGoalKeeperViewerViewModel(_modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = addGoalKeeperViewerViewModel;
        }
    }
}