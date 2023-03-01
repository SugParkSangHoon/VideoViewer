using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Services.Navigation;

namespace 영상뷰어.ViewModels
{
    public class SateliteAPISearchViewModel : ViewModelBase
    {
        private readonly INavigation _navigation;
        public SateliteAPISearchViewModel(INavigation navigation)
        {
            _navigation = navigation;            
            EndSearchDate = DateTime.Now;
            StartSearchDate = EndSearchDate.AddMonths(-1);            
        }   

        
        public virtual string UserId { get; set; }
        public string CameraType
        {
            get { return GetValue<string>(nameof(CameraType)); }
            set { SetValue(value, nameof(CameraType)); }
        }
        public string CameraArea
        {
            get { return GetValue<string>(nameof(CameraArea)); }
            set { SetValue(value, nameof(CameraArea)); }
        }
        public string FileName
        {
            get { return GetValue<string>(nameof(FileName)); }
            set { SetValue(value, nameof(FileName)); }
        }
        public string Test
        {
            get { return GetValue<string>(nameof(Test)); }
            set { SetValue(value, nameof(Test)); }
        }
        public virtual DateTime StartSearchDate { get; set; }
        public virtual DateTime EndSearchDate { get; set; }
        [Command]
        public void OnSearch()
        {

        }
        [Command]
        public void OnCancel()
        {
            _navigation.Navigate<HomeViewModel>();
        }
    }
}
