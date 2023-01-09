using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.enums;

namespace 영상뷰어.Models
{
    public class SatelliteAPIModelList :ObservableCollection<SatelliteAPIModel>
    {

    }
    public class SatelliteAPIModel
    {
        public int ID { get; set; } 
        public string? CameraType { get; set; }
        public string? CameraArea { get; set; }
        public string? Datetime { get; set; }
        public string? FilePath { get; set; }
        public string? User { get; set; }
    }
}
