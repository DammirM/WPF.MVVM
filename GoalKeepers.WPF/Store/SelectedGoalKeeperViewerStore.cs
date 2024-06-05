using GoalKeepers.Domain.Models;
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

        private GoalKeeperData _goalkeepeerdataViewer;
        public GoalKeeperData GoalKeeperDataViewer
        {
            get
            {
                return _goalkeepeerdataViewer;
            }
            set
            {

                _goalkeepeerdataViewer = value;
                SelectedGoalKeeperChanged?.Invoke();
            }
        }

        public event Action SelectedGoalKeeperChanged;
    }
}
