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

namespace 영상뷰어.ViewModels
{
    [POCOViewModel]
    public class MainViewModel :ViewModelBase
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
        public virtual MenuBarViewModel MenuBar
        {
            get=> (MenuBarViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(MenuBarViewModel)));
        }
        public virtual ViewModelBase CurrentDialogViewModel
        {
            get => (SignUpViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(SignUpViewModel)));
        }
        public virtual ViewModelBase CurrentViewModel
        {
            get => (LoginViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(LoginViewModel)));
        }
        //public bool IsBusy { get; set; } = false;
        public MainViewModel()
        {
            //string FilePath = @"E:\WPF_Project\VideoViewer\영상뷰어\bin\Debug\net6.0-windows\20230118\sw038_ko020lc_202301170000.jpg";
            //Mat image = Cv2.ImRead(FilePath, ImreadModes.Color);

            Messenger.Default.Register<bool>(this, onSetBusy);
            IsOpen = false;
        }
        private void onSetBusy(bool obj)
        {
            IsOpen = obj;
        }
    
    }
}
