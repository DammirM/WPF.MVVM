using GoalKeepers.WPF.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.WPF.Commands
{
    public class AddGoalKeeperViewerCommand : AsyncCommandBase
    {

        private readonly ModalNavigationStore _modalNavigationStore;

        public AddGoalKeeperViewerCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            _modalNavigationStore.Close();
        }
    }
}
