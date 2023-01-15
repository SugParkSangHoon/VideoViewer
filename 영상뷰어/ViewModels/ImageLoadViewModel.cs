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
    public class ImageLoadViewModel
    {
        public virtual Mat PrintMat { get; set; }
        public ImageLoadViewModel()
        {
            Messenger.Default.Register<string>(this, OnProcessMat);
        }
        [Command(isCommand: false)]
        private void OnProcessMat(string obj)
        {
            PrintMat = new Mat(obj,ImreadModes.Color);
        }
    }
}
