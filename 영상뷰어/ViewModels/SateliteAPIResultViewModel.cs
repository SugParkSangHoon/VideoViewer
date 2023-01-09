using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Models;

namespace 영상뷰어.ViewModels
{
    [POCOViewModel]
    public class SateliteAPIResultViewModel
    {        
        public virtual ObservableCollection<SatelliteAPIModel> SateliteItems { get; set; }
        public SateliteAPIResultViewModel()
        {
            Messenger.Default.Register<ObservableCollection<SatelliteAPIModel>>(this, ReceiveData);
        }

        private void ReceiveData(ObservableCollection<SatelliteAPIModel> obj)
        {
            SateliteItems = obj;
        }
    }
}
