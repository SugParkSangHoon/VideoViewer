using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using 영상뷰어.enums;

namespace 영상뷰어.ViewModels
{
    [POCOViewModel]
    public class SateliteAPISettingsViewModel
    {
        private eCameraType cameraType;
        public virtual eCameraType CameraType { get; set; }

    }
}
