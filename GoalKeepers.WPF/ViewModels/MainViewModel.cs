using GoalKeepers.WPF.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase 
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public ViewModelBase CurrentModalViewModel => _modalNavigationStore.CurrentViewModel;

        public bool IsModalOpen => _modalNavigationStore.IsOpen;

        public GoalKeeperViewersViewModel GoalKeeperViewersViewModel { get; }


        public MainViewModel(ModalNavigationStore modalNavigationStore, GoalKeeperViewersViewModel goalKeeperViewersViewModel)
        {
            _modalNavigationStore = modalNavigationStore;
            GoalKeeperViewersViewModel = goalKeeperViewersViewModel;

            _modalNavigationStore.CurrentViewModelChanged += ModalNavigationStore_CurrrentViewModelChanged;

        }

        protected override void Dispose()
        {
            _modalNavigationStore.CurrentViewModelChanged -= ModalNavigationStore_CurrrentViewModelChanged;

            base.Dispose();
        }

        private void ModalNavigationStore_CurrrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentModalViewModel));
            OnPropertyChanged(nameof(IsModalOpen));
        }


    }
}
