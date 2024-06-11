using GoalKeepers.Domain.Services;
using GoalKeepers.EntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace GoalKeepers.WPF.Store
{
    public class GoalKeeperViewersStore
    {

        private readonly IGoalKeeperService _goalKeeperService;
        private readonly List<GoalKeeperViewer> _goalkeeperViewers;

        public IEnumerable<GoalKeeperViewer> GoalKeeperViewers => _goalkeeperViewers;

        public GoalKeeperViewersStore(IGoalKeeperService goalKeeperService)
        {
            _goalKeeperService = goalKeeperService;

            _goalkeeperViewers= new List<GoalKeeperViewer>();
        }

        public event Action GoalkeepersVirwersLoaded;

        public event Action<GoalKeeperViewer> GoalKeeperViewerAdded;
        public event Action<GoalKeeperViewer> GoalKeeperViewerUpdated;
        public event Action<Guid> GoalKeeperViewerDeleted;

        public async Task Load()
        {
            IEnumerable<GoalKeeperViewer> getall = await _goalKeeperService.GetAll();

            _goalkeeperViewers.Clear();
            _goalkeeperViewers.AddRange(getall);

            GoalkeepersVirwersLoaded?.Invoke();
        }

        public async Task Add(GoalKeeperViewer goalKeeperViewer)
        {

           await _goalKeeperService.Create(goalKeeperViewer);

            _goalkeeperViewers.Add(goalKeeperViewer);

            GoalKeeperViewerAdded?.Invoke(goalKeeperViewer);
        }

        public async Task Update(GoalKeeperViewer goalKeeperViewer)
        {

            await _goalKeeperService.Update(goalKeeperViewer);

            int currrentIndex = _goalkeeperViewers.FindIndex(g => g.Id == goalKeeperViewer.Id);

            if (currrentIndex != -1)
            {
                _goalkeeperViewers[currrentIndex] = goalKeeperViewer;
            }
            else
            {
                _goalkeeperViewers.Add(goalKeeperViewer);
            }


            GoalKeeperViewerUpdated?.Invoke(goalKeeperViewer);
        }

        public async Task Delete(Guid id)
        {
            await _goalKeeperService.Delete(id);

            _goalkeeperViewers.RemoveAll(g => g.Id == id);

            GoalKeeperViewerDeleted?.Invoke(id);
        }
    }
}
