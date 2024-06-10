using GoalKeepers.WPF.Store;
using GoalKeepers.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GoalKeepers.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly SelectedGoalKeeperViewerStore _selectedGoalKeeperViewerStore;
        private readonly GoalKeeperViewersStore _goalKeeperViewersStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public App()
        {
            _modalNavigationStore= new ModalNavigationStore();
            _goalKeeperViewersStore= new GoalKeeperViewersStore();
            _selectedGoalKeeperViewerStore= new SelectedGoalKeeperViewerStore(_goalKeeperViewersStore);
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            GoalKeeperViewersViewModel goalKeeperViewersViewModel = new GoalKeeperViewersViewModel(
                _goalKeeperViewersStore,
                _selectedGoalKeeperViewerStore,
                _modalNavigationStore);
            MainWindow = new MainWindow()
            { 
                DataContext = new MainViewModel(_modalNavigationStore, goalKeeperViewersViewModel) 
            };

            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
