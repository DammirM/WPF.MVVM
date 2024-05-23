using GoalKeepers.WPF.Commands;
using GoalKeepers.WPF.Models;
using GoalKeepers.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GoalKeepers.WPF.State.Navigators
{
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _curentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _curentViewModel;
            }
            set
            {
                _curentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);

        
    }
}

