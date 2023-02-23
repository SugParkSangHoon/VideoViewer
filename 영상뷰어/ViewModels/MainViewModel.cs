using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Microsoft.Extensions.DependencyInjection;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Stores;

namespace 영상뷰어.ViewModels
{
    [POCOViewModel]
    public class MainViewModel : ViewModelBase
    {                
        public bool IsOpen
        {
            get => GetValue<bool>(nameof(IsOpen));
            set => SetValue(value, nameof(IsOpen));
        }
        //public virtual bool IsOpen { get; set; } = true;
        public virtual MenuBarViewModel MenuBar
        {
            get => (MenuBarViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(MenuBarViewModel)));
        }         
        public ViewModelBase CurrentDialogViewModel
        {
            get => GetValue<ViewModelBase>(nameof(CurrentDialogViewModel));
            set
            {
                IsOpen = true;                
                SetValue(value, nameof(CurrentDialogViewModel));
            }
        }
        public ViewModelBase CurrentViewModel
        {
            get => GetValue< ViewModelBase>(nameof(CurrentViewModel));
            set
            {
                IsOpen = false;
                IsMenuOpen = false;
                SetValue(value, nameof(CurrentViewModel));

            }
        }        
        public virtual bool IsMenuOpen { get; set; } = false;
        public MainViewModel()
        {
            //string FilePath = @"E:\WPF_Project\VideoViewer\영상뷰어\bin\Debug\net6.0-windows\20230118\sw038_ko020lc_202301170000.jpg";
            //Mat image = Cv2.ImRead(FilePath, ImreadModes.Color);
            //CurrentViewModel = (LoginViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(LoginViewModel)));
            CurrentViewModel = (HomeViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(HomeViewModel)));
            Messenger.Default.Register<DialogDataStore>(this, onDialogRecvData);

            //CurrentDialogViewModel = (ImageLoadViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(ImageLoadViewModel)));
            //Messenger.Default.Send<string>(@"F:\wpf\VideoViewer\영상뷰어\bin\Debug\net6.0-windows\20230223\sw038_ko020lc_202302220000.jpg");
            //IsOpen = true;
        }

        private void onDialogRecvData(DialogDataStore obj)
        {
            switch (obj.DilaogType)
            {
                case enums.eDialog.ImageLode:
                    CurrentDialogViewModel = (ImageLoadViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(ImageLoadViewModel)));
                    Messenger.Default.Send<string>(@"F:\wpf\VideoViewer\영상뷰어\bin\Debug\net6.0-windows\20230223\sw038_ko020lc_202302220000.jpg");
                    break;
                case enums.eDialog.SingnUp:
                    CurrentDialogViewModel = (SignUpViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(SignUpViewModel)));
                    break;
            }

        }

        private void onSetBusy(bool obj)
        {
            IsOpen = obj;
        }
        [Command]
        public virtual void onMenuOpen()
        {
            IsMenuOpen = !IsMenuOpen;
            //IsOpen = !IsOpen;
        }

    }
}
