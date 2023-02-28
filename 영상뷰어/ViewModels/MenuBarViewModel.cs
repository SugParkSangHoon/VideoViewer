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
using 영상뷰어.Stores;

namespace 영상뷰어.ViewModels
{
    public class MenuBarViewModel :ViewModelBase
    {
        
        private readonly INavigation _navigation;
        private readonly AccountStore _accountStore;
        public MenuBarViewModel(INavigation navigation,AccountStore accountStore)
        {
            _navigation = navigation;
            _accountStore = accountStore;
            _accountStore.CurrentAccountChanged += OnCurrentAccountChange;
        }

        private void OnCurrentAccountChange()
        {
            IsLogin = _accountStore.IsLoggedIn;
        }

        public virtual bool IsLogin { get; set; }

        [Command]
        public virtual void onHomeNavigate()
        {
            _navigation.Navigate<HomeViewModel>();
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
