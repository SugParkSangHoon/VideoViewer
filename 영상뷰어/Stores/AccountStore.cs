using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Interfaces;
using 영상뷰어.Models;

namespace 영상뷰어.Stores
{
    public class AccountStore : IDataStore
    {
        private UserData _currentAccount;
        public UserData CurrentAccount
        {
            get => _currentAccount;
            set
            {
                _currentAccount = value;
                CurrentAccountChanged?.Invoke();
            }
        }
        public bool IsLoggedIn => CurrentAccount != null;
        public event Action CurrentAccountChanged;
        public void Logout()
        {
            CurrentAccount = null;
        }
    }
}
