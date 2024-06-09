using GoalKeepers.WPF.Models;
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
        public GoalKeeperViewer GoalKeeperViewer { get; }
        public string LastName => GoalKeeperViewer.LastName;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public GoalKeeperViewersListingItemViewModel(GoalKeeperViewer goalKeeperViewer, ICommand editCommand)
        {
            GoalKeeperViewer = goalKeeperViewer;
            EditCommand = editCommand;
        }
    }
}
