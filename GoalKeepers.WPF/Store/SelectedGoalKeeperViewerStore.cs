using GoalKeepers.Domain.Models;
using GoalKeepers.WPF.Models;
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
    }
}
