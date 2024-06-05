using GoalKeepers.Domain.Models;
using GoalKeepers.WPF.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.WPF.ViewModels
{
   public class GoalKeepersViwersDetailsViewModel : ViewModelBase
    {
        private readonly SelectedGoalKeeperViewerStore _selectedGoalKeeperStore;

        private GoalKeeperData SelectedGoalkeeperViewer => _selectedGoalKeeperStore.SelectedGoalkeeperViewer;

        public bool HasSelectedGoalKeeper => SelectedGoalkeeperViewer != null;

        public string LastName => SelectedGoalkeeperViewer?.LastName ?? "Unknown";
        public string Crosses => (SelectedGoalkeeperViewer?.Crosses ?? false) ? "Yes" : "No";
        public string GoalLine => (SelectedGoalkeeperViewer?.GoalLine ?? false) ? "Yes" : "No";

        public GoalKeepersViwersDetailsViewModel(SelectedGoalKeeperViewerStore selectedGoalKeeperStore)
        {
            _selectedGoalKeeperStore = selectedGoalKeeperStore;
        }
    }
}
