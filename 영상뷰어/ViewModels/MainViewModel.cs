using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
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
        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value, "IsBusy"); }
        }
        //public bool IsBusy { get; set; } = false;
        public MainViewModel()
        {
            //string FilePath = @"E:\WPF_Project\VideoViewer\영상뷰어\bin\Debug\net6.0-windows\20230118\sw038_ko020lc_202301170000.jpg";
            //Mat image = Cv2.ImRead(FilePath, ImreadModes.Color);

            Messenger.Default.Register<bool>(this, onSetBusy);
            //IsBusy = false;
        }
        private void onSetBusy(bool obj)
        {
            IsBusy = obj;
        }
    
    }
}
