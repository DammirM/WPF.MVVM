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
    internal class DeleteGoalKeeperViewerCommand : AsyncCommandBase
    {

        private readonly GoalKeeperViewersListingItemViewModel _goalKeeperViewersListingItemViewModel;
        private readonly GoalKeeperViewersStore _goalKeeperViewersStore;

        public DeleteGoalKeeperViewerCommand(GoalKeeperViewersListingItemViewModel goalKeeperViewersListingItemViewModel, GoalKeeperViewersStore goalKeeperViewersStore)
        {
            _goalKeeperViewersListingItemViewModel = goalKeeperViewersListingItemViewModel;
            _goalKeeperViewersStore = goalKeeperViewersStore;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            GoalKeeperViewer goalKeeperViewer = _goalKeeperViewersListingItemViewModel.GoalKeeperViewer;

            try
            {
                await _goalKeeperViewersStore.Delete(goalKeeperViewer.Id);
            }
            catch (Exception)
            {

                throw;
            }

            
        }
    }
}
