using GoalKeepers.EntityFrameWork.Models;
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
        public string Team => SelectedGoalkeeperViewer?.Team ?? "Unknown";
        public string Crosses => (SelectedGoalkeeperViewer?.Crosses ?? false) ? "Yes" : "No";
        public string GoalLineKeeper => (SelectedGoalkeeperViewer?.GoalLineKeeper ?? false) ? "Yes" : "No";
        public string Reflexes => (SelectedGoalkeeperViewer?.Reflexes ?? false) ? "Yes" : "No";
        public string AttackingKeeper => (SelectedGoalkeeperViewer?.AttackingKeeper ?? false) ? "Yes" : "No";
        public string GoodWithFeet => (SelectedGoalkeeperViewer?.GoodWithFeet ?? false) ? "Yes" : "No";
        public string SweeperKeeper => (SelectedGoalkeeperViewer?.SweeperKeeper ?? false) ? "Yes" : "No";

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
            OnPropertyChanged(nameof(Team));
            OnPropertyChanged(nameof(Crosses));
            OnPropertyChanged(nameof(GoalLineKeeper));
            OnPropertyChanged(nameof(Reflexes));
            OnPropertyChanged(nameof(AttackingKeeper));
            OnPropertyChanged(nameof(GoodWithFeet));
            OnPropertyChanged(nameof(SweeperKeeper));
        }
    }
}
