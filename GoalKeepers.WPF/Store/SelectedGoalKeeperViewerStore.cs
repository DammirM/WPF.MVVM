using GoalKeepers.EntityFrameWork.Models;
using GoalKeepers.EntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GoalKeepers.WPF.Store
{
    public class SelectedGoalKeeperViewerStore
    {
        private readonly GoalKeeperViewersStore _goalKeeperViewersStore;

        private GoalKeeperViewer _selectedGoalKeeperViewer;

        public GoalKeeperViewer SelectedGoalKeeperViewer
        {
            get
            {
                return _selectedGoalKeeperViewer;
            }
            set
            {

                _selectedGoalKeeperViewer = value;
                SelectedGoalKeeperChanged?.Invoke();
            }
        }

        public event Action SelectedGoalKeeperChanged;

        public SelectedGoalKeeperViewerStore(GoalKeeperViewersStore goalKeeperViewersStore)
        {
            _goalKeeperViewersStore = goalKeeperViewersStore;

            _goalKeeperViewersStore.GoalKeeperViewerUpdated += GoalKeeperViewersStore_GoalKeeperViewerUpdated;
        }

        private void GoalKeeperViewersStore_GoalKeeperViewerUpdated(GoalKeeperViewer goalKeeperViewer)
        {
            if (goalKeeperViewer.Id == SelectedGoalKeeperViewer?.Id)
            {
                SelectedGoalKeeperViewer= goalKeeperViewer;
            }
        }
    }
}
