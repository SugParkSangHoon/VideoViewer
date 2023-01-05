using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using 영상뷰어.ViewModels;
using 영상뷰어.Interfaces;
using 영상뷰어.Services;

namespace 영상뷰어
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; }
        public App()
        {
            Services = ConfigureServices();
            this.InitializeComponent();
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient(typeof(MainViewModel));
            services.AddTransient(typeof(SateliteAPISettingsViewModel));

            services.AddSingleton<IDataBase, MssqlDatabase>(obj => new MssqlDatabase());
            services.AddSingleton<ISettingService, SettingService>(obj => new SettingService());

            return services.BuildServiceProvider();
        }
    }
}
