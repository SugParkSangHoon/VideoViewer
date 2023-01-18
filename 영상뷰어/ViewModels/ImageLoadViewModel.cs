using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Interfaces;

namespace 영상뷰어.ViewModels
{

    [POCOViewModel]
    public class ImageLoadViewModel : ViewModelBase, IContext
    {
        public virtual Mat PrintMat { get; set; }
        public string TestText { get; set; }    

        public ImageLoadViewModel()
        {
            Messenger.Default.Register<string>(this, OnProcessMat);
            TestText = "Check In?";
        }
        [Command(isCommand: false)]
        private void OnProcessMat(string obj)
        {
            Mat image = Cv2.ImRead(obj, ImreadModes.Color);
            PrintMat = image;
        }
        public void onTest()
        {
            TestText = "OK";
        }
    }
}
