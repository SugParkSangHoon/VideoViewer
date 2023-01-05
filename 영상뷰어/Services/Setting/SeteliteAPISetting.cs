using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.enums;

namespace 영상뷰어.Services.Setting
{
    public class SeteliteAPISetting
    {
        public eCameraType CameraType { get; set; }
        public eCameraArea CameraArea { get; set; }
        public string? Datetime { get; set; }
    }
}
