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

        private string _team;

        public string Team
        {
            get
            {
                return _team;
            }
            set
            {
                _team = value;
                OnPropertyChanged(nameof(Team));
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

        private bool _goalLineKeeper;

        public bool GoalLineKeeper
        {
            get
            {
                return _goalLineKeeper;
            }
            set
            {
                _goalLineKeeper = value;
                OnPropertyChanged(nameof(GoalLineKeeper));
            }
        }

        private bool _reflexes;

        public bool Reflexes
        {
            get
            {
                return _reflexes;
            }
            set
            {
                _reflexes = value;
                OnPropertyChanged(nameof(Reflexes));
            }
        }

        private bool _attackingKeeper;

        public bool AttackingKeeper
        {
            get
            {
                return _attackingKeeper;
            }
            set
            {
                _attackingKeeper = value;
                OnPropertyChanged(nameof(AttackingKeeper));
            }
        }



        private bool _goodWithFeet;

        public bool GoodWithFeet
        {
            get
            {
                return _goodWithFeet;
            }
            set
            {
                _goodWithFeet = value;
                OnPropertyChanged(nameof(GoodWithFeet));
            }
        }

        private bool _sweeperKeeper;

        public bool SweeperKeeper
        {
            get
            {
                return _sweeperKeeper;
            }
            set
            {
                _sweeperKeeper = value;
                OnPropertyChanged(nameof(SweeperKeeper));
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







