using Microsoft.Extensions.DependencyInjection;
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

            service.AddTransient<AccountViewModel>();
            service.AddTransient<MainViewModel>();

            service.AddSingleton<MainWindow>(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });
            _serviceProvider = service.BuildServiceProvider();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = _serviceProvider.GetService<MainWindow>();
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
