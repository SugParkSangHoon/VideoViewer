using NavigationMVVM.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationMVVM.ViewModels
{
    public class MainViewModel :ViewModelBase
    {
        private readonly NavigationStore _navigateionStroe;

        
        public ViewModelBase CurrentViewModel => _navigateionStroe.CurrentViewModel;
        //public MainViewModel(NavigationStore navigateionStroe)
        //{
        //    _navigateionStroe = navigateionStroe;

        //    _navigateionStroe.CurrentViewModelChanged += OnCurrentViewModelChanged;
        //}

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
