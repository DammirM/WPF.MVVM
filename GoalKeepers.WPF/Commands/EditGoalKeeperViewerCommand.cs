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
    public class EditGoalKeeperViewerCommand : AsyncCommandBase
    {

        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly EditGoalKeeperViewerViewModel _editGoalKeeperViewerViewModel;
        private readonly GoalKeeperViewersStore _goalKeeperViewersStore;
        

        public EditGoalKeeperViewerCommand(EditGoalKeeperViewerViewModel editGoalKeeperViewerViewModel, GoalKeeperViewersStore goalKeeperViewersStore, ModalNavigationStore modalNavigationStore)
        {
            _editGoalKeeperViewerViewModel = editGoalKeeperViewerViewModel;
            _modalNavigationStore = modalNavigationStore;
            _goalKeeperViewersStore= goalKeeperViewersStore;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            GoalKeeperViewerDetailsFormViewModel formViewModel = _editGoalKeeperViewerViewModel.GoalKeeperViewerDetailsFormViewModel;

            GoalKeeperViewer goalkeeperViewer = new GoalKeeperViewer(
                _editGoalKeeperViewerViewModel.GoalKeeperViewerId, 
                formViewModel.LastName, 
                formViewModel.Team, 
                formViewModel.Crosses, 
                formViewModel.GoalLineKeeper, 
                formViewModel.Reflexes, 
                formViewModel.AttackingKeeper, 
                formViewModel.GoodWithFeet, 
                formViewModel.SweeperKeeper);

            try
            {
                await _goalKeeperViewersStore.Update(goalkeeperViewer);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
