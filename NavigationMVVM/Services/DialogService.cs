using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationMVVM.Services
{
    public class DialogService<TViewModel> : IDialog where TViewModel : ViewModelBase
    {
        private readonly TViewModel _viewModel;
        public DialogService(TViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public void Open()
        {
            
        }       
    }
}
