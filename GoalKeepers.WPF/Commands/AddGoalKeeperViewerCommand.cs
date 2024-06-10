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
    public class AddGoalKeeperViewerCommand : AsyncCommandBase
    {
        private readonly AddGoalKeeperViewerViewModel _addGoalKeeperViewerViewModel;
        private readonly GoalKeeperViewersStore _goalKeeperViewersStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public AddGoalKeeperViewerCommand(AddGoalKeeperViewerViewModel addGoalKeeperViewerViewModel, GoalKeeperViewersStore goalKeeperViewersStore, ModalNavigationStore modalNavigationStore)
        {
            _addGoalKeeperViewerViewModel = addGoalKeeperViewerViewModel;
            _goalKeeperViewersStore = goalKeeperViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object? parameter)
        {

            GoalKeeperViewerDetailsFormViewModel formViewModel = _addGoalKeeperViewerViewModel.GoalKeeperViewerDetailsFormViewModel;

            GoalKeeperViewer goalkeeperViewer = new GoalKeeperViewer(Guid.NewGuid(), formViewModel.LastName, formViewModel.Team, formViewModel.Crosses, formViewModel.GoalLineKeeper,
                formViewModel.Reflexes, formViewModel.AttackingKeeper, formViewModel.GoodWithFeet, formViewModel.AttackingKeeper);

            try
            {
                await _goalKeeperViewersStore.Add(goalkeeperViewer);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
