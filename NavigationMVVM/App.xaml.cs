using Microsoft.Extensions.DependencyInjection;
using NavigationMVVM.Services;
using NavigationMVVM.Stores;
using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NavigationMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;
        public App()
        {
            IServiceCollection service = new ServiceCollection();

            service.AddSingleton<PeopleStore>();
            service.AddSingleton<NavigationStore>();
            service.AddSingleton<DialogStore>();
            service.AddSingleton<AccountStore>();

            service.AddSingleton<INavigationService>(s => CreateHomeNavigationService(s));
            service.AddTransient<HomeViewModel>();
            service.AddTransient<NavigationBarViewModel>();
            service.AddTransient<MainViewModel>();

            service.AddSingleton<MainWindow>(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });
            _serviceProvider = service.BuildServiceProvider();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            INavigationService initialNavigateionService = _serviceProvider.GetRequiredService<INavigationService>();
            initialNavigateionService.Navigate();
            MainWindow = _serviceProvider.GetService<MainWindow>();
            MainWindow.Show();

            base.OnStartup(e);
        }
        private INavigationService CreateHomeNavigationService(IServiceProvider s)
        {
            return new LayoutNavigationService<HomeViewModel>(
               _serviceProvider.GetRequiredService<NavigationStore>(),
               () => _serviceProvider.GetRequiredService<HomeViewModel>(),
               () => _serviceProvider.GetRequiredService<NavigationBarViewModel>());
        }
        private NavigationBarViewModel CreateNavigationBarModel(IServiceProvider serviceProvider)
        {
            return new NavigationBarViewModel();
        }

    }
}
