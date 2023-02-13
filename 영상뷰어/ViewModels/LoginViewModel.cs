using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 영상뷰어.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public virtual string UserPassword { get; set; }
        public virtual string UserId { get; set; }
        public LoginViewModel() 
        {
            
        }
    }
}
