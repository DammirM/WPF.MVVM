using GoalKeepers.EntityFrameWork.Models;
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
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly GoalKeeperViewersListingItemViewModel _goalKeeperViewersListingItemViewModel;
        private readonly GoalKeeperViewersStore _goalKeeperViewersStore;

        public OpenEditGoalKeeperViewerCommand(GoalKeeperViewersListingItemViewModel goalKeeperViewersListingItemViewModel, GoalKeeperViewersStore goalKeeperViewersStore, ModalNavigationStore modalNavigationStore)
        {
            _goalKeeperViewersListingItemViewModel = goalKeeperViewersListingItemViewModel;
            _goalKeeperViewersStore = goalKeeperViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {

            GoalKeeperViewer goalKeeperViewer = _goalKeeperViewersListingItemViewModel.GoalKeeperViewer;

            EditGoalKeeperViewerViewModel editGoalKeeperViewerViewModel = new EditGoalKeeperViewerViewModel(goalKeeperViewer, _goalKeeperViewersStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editGoalKeeperViewerViewModel;
        }
    }
}
