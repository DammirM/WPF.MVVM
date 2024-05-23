using GoalKeepers.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GoalKeepers.WPF.State.Navigators
{

    public enum ViewType
    {
        Name,
        Attributes,
        Height
    }
    public interface INavigator
    {

        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
