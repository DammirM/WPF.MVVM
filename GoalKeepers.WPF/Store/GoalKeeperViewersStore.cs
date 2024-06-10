using GoalKeepers.EntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.WPF.Store
{
    public class GoalKeeperViewersStore
    {
        public event Action<GoalKeeperViewer> GoalKeeperViewerAdded;
        public event Action<GoalKeeperViewer> GoalKeeperViewerUpdated;

        public async Task Add(GoalKeeperViewer goalKeeperViewer)
        {
            GoalKeeperViewerAdded?.Invoke(goalKeeperViewer);
        }

        public async Task Update(GoalKeeperViewer goalKeeperViewer)
        {
            GoalKeeperViewerUpdated?.Invoke(goalKeeperViewer);
        }
    }
}
