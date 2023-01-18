using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Base;
using 영상뷰어.Interfaces;

namespace 영상뷰어.Views.Windows
{
    public class DialogViewModel : ViewModelBase, IDialogContext
    {        
        public IContext Context { get; set; }
    }
}
