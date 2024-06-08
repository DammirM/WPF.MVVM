using GoalKeepers.Domain.Models;
using GoalKeepers.WPF.Models;
using GoalKeepers.WPF.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.WPF.ViewModels
{
   public class GoalKeeperViewersDetailsViewModel : ViewModelBase
    {
        private readonly SelectedGoalKeeperViewerStore _selectedGoalKeeperStore;

        private GoalKeeperViewer SelectedGoalkeeperViewer => _selectedGoalKeeperStore.SelectedGoalKeeperViewer;

        public bool HasSelectedGoalKeeperViewer => SelectedGoalkeeperViewer != null;

        public string LastName => SelectedGoalkeeperViewer?.LastName ?? "Unknown";
        public string Crosses => (SelectedGoalkeeperViewer?.Crosses ?? false) ? "Yes" : "No";
        public string GoalLine => (SelectedGoalkeeperViewer?.GoalLine ?? false) ? "Yes" : "No";

        public GoalKeeperViewersDetailsViewModel(SelectedGoalKeeperViewerStore selectedGoalKeeperStore)
        {
            _selectedGoalKeeperStore = selectedGoalKeeperStore;

            _selectedGoalKeeperStore.SelectedGoalKeeperChanged += _selectedGoalKeeperStore_SelectedGoalKeeperChanged;
        }

        protected override void Dispose()
        {

            _selectedGoalKeeperStore.SelectedGoalKeeperChanged += _selectedGoalKeeperStore_SelectedGoalKeeperChanged;

            base.Dispose();
        }

        private void _selectedGoalKeeperStore_SelectedGoalKeeperChanged()
        {
            OnPropertyChanged(nameof(HasSelectedGoalKeeperViewer));
            OnPropertyChanged(nameof(LastName));
            OnPropertyChanged(nameof(Crosses));
            OnPropertyChanged(nameof(GoalLine));
        }
    }
}
