using GoalKeepers.WPF.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.WPF.Commands
{
    public class LoadGoalKeeperViewersCommand : AsyncCommandBase
    {
        private readonly GoalKeeperViewersStore _goalKeeperViewersStore;

        public LoadGoalKeeperViewersCommand(GoalKeeperViewersStore goalKeeperViewersStore)
        {
            _goalKeeperViewersStore = goalKeeperViewersStore;
        }

        public override async Task ExecuteAsync(object? parameter)
        {

            try
            {
                await _goalKeeperViewersStore.Load();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
