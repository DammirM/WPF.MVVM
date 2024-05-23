using GoalKeepers.WPF.State.Navigators;
using GoalKeepers.WPF.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GoalKeepers.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Name:
                        _navigator.CurrentViewModel = new NameViewModel();
                        break;
                    case ViewType.Attributes:
                        _navigator.CurrentViewModel = new AttributesViewModel();
                        break;
                    case ViewType.Height:
                        _navigator.CurrentViewModel = new HeightViewModel();
                        break;
                }
            }
        }
    }
}