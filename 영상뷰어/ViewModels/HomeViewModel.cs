using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Stores;

namespace 영상뷰어.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly AccountStore _account;
        public virtual string UserId { get; set; }
        public HomeViewModel(AccountStore account)
        {
            this._account = account;
            if(_account.CurrentAccount is not null)
                UserId = _account.CurrentAccount.Id;
        }
    }
}
