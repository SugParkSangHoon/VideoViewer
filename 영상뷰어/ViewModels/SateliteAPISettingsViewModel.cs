using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using 영상뷰어.enums;
using 영상뷰어.Models;

namespace 영상뷰어.ViewModels
{
    [POCOViewModel]
    public class SateliteAPISettingsViewModel : ViewModelBase
    {        
        public SatelliteAPIModel SatelliteAPIModel { get; set; }
        public virtual eCameraType CameraType { get; set; }
        public eCameraArea CameraArea { get; set; }
        public SateliteAPISettingsViewModel()
        {

        }
    }   
}
