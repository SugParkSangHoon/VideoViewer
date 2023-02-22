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
        //private bool _isBusy;
        //public bool IsBusy
        //{
        //    get { return GetProperty(()=>_isBusy); }
        //    set { SetProperty(()=>_isBusy, value); }
        //}
        private bool _isOpen;
        public bool IsOpen
        {
            get { return _isOpen; }
            set { SetProperty(ref _isOpen, value, nameof(IsOpen)); }
        }
        //public virtual bool IsOpen { get; set; } = true;
        public virtual MenuBarViewModel MenuBar
        {
            get => (MenuBarViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(MenuBarViewModel)));
        }
        private ViewModelBase _currentDialogViewModel;
        public ViewModelBase CurrentDialogViewModel
        {
            get => _currentDialogViewModel;
            set
            {
                IsOpen = true;
                _currentDialogViewModel = value;
                SetProperty(ref _currentDialogViewModel, value, nameof(CurrentDialogViewModel));
            }
        }


        //public virtual ViewModelBase CurrentViewModel
        //{
        //    get => (SateliteSearchViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(SateliteSearchViewModel)));
        //}
        public virtual ViewModelBase CurrentViewModel { get; set; }
        public virtual bool IsMenuOpen { get; set; } = false;
        public MainViewModel()
        {
            //string FilePath = @"E:\WPF_Project\VideoViewer\영상뷰어\bin\Debug\net6.0-windows\20230118\sw038_ko020lc_202301170000.jpg";
            //Mat image = Cv2.ImRead(FilePath, ImreadModes.Color);
            //CurrentViewModel = (LoginViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(LoginViewModel)));
            CurrentViewModel = (HomeViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(HomeViewModel)));
            Messenger.Default.Register<DialogDataStore>(this, onDialogRecvData);
            //Messenger.Default.Unregister<DialogDataStore>(this, onDialogRecvData);
            //CurrentDialogViewModel = (ImageLoadViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(ImageLoadViewModel)));
        }

        private void onDialogRecvData(DialogDataStore obj)
        {
            switch (obj.DilaogType)
            {
                case enums.eDialog.ImageLode:
                    CurrentDialogViewModel = (ImageLoadViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(ImageLoadViewModel)));
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
            IsOpen = !IsOpen;
        }

    }
}
