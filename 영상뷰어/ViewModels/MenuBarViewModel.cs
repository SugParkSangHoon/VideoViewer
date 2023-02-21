using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Services.Navigation;
using Microsoft.Extensions.DependencyInjection;

namespace 영상뷰어.ViewModels
{
    public class MenuBarViewModel :ViewModelBase
    {
        private readonly INavigation _navigation;
        public MenuBarViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }
        [Command]
        public virtual void onHomeNavigate()
        {
            
        }
        [Command]
        public virtual void onLoginNavigate()
        {
           // var data = (LoginViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(LoginViewModel)));
            _navigation.Navigate<LoginViewModel>();
        }
        [Command]
        public virtual void onSateliteSearch()
        {
            _navigation.Navigate<SateliteSearchViewModel>();
        }
    }
}
