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

        public App()
        {
            _selectedGoalKeeperViewerStore= new SelectedGoalKeeperViewerStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            MainWindow = new MainWindow()
            { 
                DataContext = new GoalKeeperViewersViewModel(_selectedGoalKeeperViewerStore) 
            };

            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
