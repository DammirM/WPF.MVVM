using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GoalKeepers.WPF.ViewModels
{
    public class GoalKeeperViewerDetailsFormViewModel : ViewModelBase
    {
        private string _lastName;
        
        public string LastName
        {
            get 
            {
                return _lastName;
            } 
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        private bool _crosses;

        public bool Crosses
        {
            get
            {
                return _crosses;
            }
            set
            {
                _crosses = value;
                OnPropertyChanged(nameof(Crosses));
            }
        }

        private bool _goalLine;

        public bool GoalLine
        {
            get
            {
                return _goalLine;
            }
            set
            {
                _goalLine = value;
                OnPropertyChanged(nameof(GoalLine));
            }
        }

        public bool CanSubmit => !string.IsNullOrEmpty(LastName);
        public ICommand SubmitCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public GoalKeeperViewerDetailsFormViewModel(ICommand submitCommand, ICommand cancelCommand)
        {
            SubmitCommand = submitCommand;
            CancelCommand = cancelCommand;
        }
    }

    
}







