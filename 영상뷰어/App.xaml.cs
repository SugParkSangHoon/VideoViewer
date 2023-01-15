using System;
using Microsoft.Extensions.DependencyInjection;
using DevExpress.Mvvm.POCO;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using 영상뷰어.ViewModels;
using 영상뷰어.Interfaces;
using 영상뷰어.Services;
using DevExpress.Mvvm;
using Microsoft.Extensions.Hosting;

namespace 영상뷰어
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        private readonly IHost host;
        public App()
        {
            Messenger.Default = new Messenger(isMultiThreadSafe: true, actionReferenceType: ActionReferenceType.WeakReference);
            host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {                                        
                    service.AddTransient(ViewModelSource.GetPOCOType(typeof(MainViewModel)));
                    service.AddTransient(ViewModelSource.GetPOCOType(typeof(SateliteAPISettingsViewModel)));
                    service.AddTransient(ViewModelSource.GetPOCOType(typeof(SateliteAPIResultViewModel)));
                    service.AddSingleton<ISettingService, SettingService>(obj => new SettingService());
                    
                })
                .Build();
            
            ServiceProvider = host.Services;
            
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            await host.StartAsync();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            using (host)
            {
                await host.StopAsync(TimeSpan.FromSeconds(5));
            }

            base.OnExit(e);
        }
        //private static IServiceProvider ConfigureServices()
        //{
        //    var services = new ServiceCollection();
        //    services.AddTransient(typeof(MainViewModel));
        //    services.AddTransient(typeof(SateliteAPISettingsViewModel));

        //    services.AddSingleton<IDataBase, MssqlDatabase>(obj => new MssqlDatabase());
        //    services.AddSingleton<ISettingService, SettingService>(obj => new SettingService());

        //    return services.BuildServiceProvider();
        //}
    }
}
