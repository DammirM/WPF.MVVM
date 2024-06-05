using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GoalKeepers.WPF.ViewModels
{
    public class GoalKeeperViewersListingItemViewModel : ViewModelBase
    {

        public string LastName { get; }

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public GoalKeeperViewersListingItemViewModel(string lastName)
        {
            LastName = lastName;
        }
    }
}
