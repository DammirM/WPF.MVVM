using GoalKeepers.EntityFrameWork.Models;
using GoalKeepers.WPF.Commands;
using GoalKeepers.EntityFrameWork.Models;
using GoalKeepers.WPF.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GoalKeepers.WPF.ViewModels
{
    public class GoalKeeperViewersListingItemViewModel : ViewModelBase
    {
        private GoalKeeperViewersStore goalKeeperViewersStore;
        private ModalNavigationStore modalNavigationStore;

        public GoalKeeperViewer GoalKeeperViewer { get; private set; }
        public string LastName => GoalKeeperViewer.LastName;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public GoalKeeperViewersListingItemViewModel(GoalKeeperViewer goalKeeperViewer, GoalKeeperViewersStore goalKeeperViewersStore, ModalNavigationStore modalNavigationStore)
        {
            GoalKeeperViewer = goalKeeperViewer;

            EditCommand = new OpenEditGoalKeeperViewerCommand(this, goalKeeperViewersStore, modalNavigationStore);
        }

        public void Update(GoalKeeperViewer goalKeeperViewer)
        {
            GoalKeeperViewer = goalKeeperViewer;

            OnPropertyChanged(nameof(LastName));
        }
    }
}
