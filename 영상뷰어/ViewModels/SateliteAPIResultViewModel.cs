using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using 영상뷰어.Interfaces;
using 영상뷰어.Models;
using 영상뷰어.Services;
using 영상뷰어.Services.DataBase;
using 영상뷰어.Views.Windows;

namespace 영상뷰어.ViewModels
{
    [POCOViewModel]
    public class SateliteAPIResultViewModel :ViewModelBase
    {
        
        public virtual ObservableCollection<SatelliteData>? SateliteItems { get; set; }
        public virtual SatelliteData SelectedItem { get; set; }
        public SateliteAPIResultViewModel()
        {        
            Messenger.Default.Register<ObservableCollection<SatelliteData>>(this, ReceiveData);
        }

        private void ReceiveData(ObservableCollection<SatelliteData> obj)
        {
            SateliteItems = obj;
        }
        [Command]
        public virtual void SelectionChanged(object selectedItem)
        {

        }
        public  virtual async Task onSave()
        {
            if (SateliteItems.Any() == false)
                return;

            using (var context = new SateliteDbContext())
            {
                var serviceProvider = new ServiceCollection().AddLogging().BuildServiceProvider();
                var factory = serviceProvider.GetService<ILoggerFactory>();

                var isSuecess = context.Database.EnsureCreated(); //데이터 베이스가 만들어져 있는지 확인
                                                  //[A] Arrange :1 번 데이터를 아래 항목으로 저장
                var repository = new SatelliteRepository(context, factory);
                foreach(var item in SateliteItems)
                {
                    await repository.AddAsync(item);
                }               
            }
        }
        //[Command]
        //public virtual void onButtonLoad()
        //{
        //    //_idialogService.Register(enums.EDialogHostType.BasicType, typeof(Views.Windows.Dialog));
        //    if(_dialogService.CheckActivate("TEST") is true)
        //    {

        //    }else
        //    {
        //        //var resultViewModel = (ImageLoadViewModel)App.ServiceProvider.GetRequiredService
        //        //    (ViewModelSource.GetPOCOType(typeof(ImageLoadViewModel)));
        //        _dialogService.SetVM(new ImageLoadViewModel(), "TEST", 500, 800, enums.EDialogHostType.BasicType,false);
        //    }
            
        //   // _idialogService.Set(new ImageLoadViewModel());
        //    Messenger.Default.Send(SelectedItem.FilePath);
        //}

    }
}
