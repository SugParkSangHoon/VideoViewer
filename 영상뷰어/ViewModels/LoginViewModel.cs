using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Helpers;
using 영상뷰어.Services.DataBase;
using 영상뷰어.Stores;

namespace 영상뷰어.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public virtual string UserPassword { get; set; }
        public virtual string UserId { get; set; }
        private readonly AccountStore _accountStore;
        public LoginViewModel(AccountStore accountStore) 
        {
            _accountStore = accountStore;
        }
        [Command]
        public void onSignUp()
        {            
            Messenger.Default.Send(new DialogDataStore
            {
                DilaogType = enums.eDialog.SingnUp,                
            });
        }
        [Command]
        public async Task onSigIn()
        {
            using (var context = new UserDataDbContext())
            {
                var serviceProvider = new ServiceCollection().AddLogging().BuildServiceProvider();
                var logFactory = serviceProvider.GetService<ILoggerFactory>();
                var isSuecess = context.Database.EnsureCreated();
                var repository = new UserRepository(context, logFactory);
                var checedCncrypedPassword = new PasswordEncryptionHelper(UserPassword).GetSHAEncryptedPassword();

                var user = await repository.GetByIdAsync(UserId);
                if (user == null)
                    return;
                if(string.Compare(user.Password, checedCncrypedPassword, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    Console.WriteLine("로그인 성공");
                    _accountStore.CurrentAccount = user;
                }
                else
                {
                    Console.WriteLine("로그인 실패");
                }

            }
        }
    }
}
