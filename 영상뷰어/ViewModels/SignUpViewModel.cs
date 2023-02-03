using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Models;
using 영상뷰어.Services.DataBase;

namespace 영상뷰어.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        public virtual string? UserId {  get; set; }
        public virtual string? UserPassword { get; set; }
        public virtual string? UserEmail { get; set; }
        public virtual string? UserPhoneNumber { get; set; } 
        public SignUpViewModel() { }

        [Command]
        public virtual async Task onSignUpOk()
        {
            using (var context = new UserDataDbContext())
            {
                var serviceProvider = new ServiceCollection().AddLogging().BuildServiceProvider();
                var logFactory = serviceProvider.GetService<ILoggerFactory>();
                var isSuecess = context.Database.EnsureCreated();
                var repository = new UserRepository(context,logFactory);
                var userData = new UserData
                {
                    Id = UserId,
                    Password = UserPassword,
                    Email = UserEmail,
                    PhoneNumber = UserPhoneNumber,
                    JoinDatetime = DateTime.Now
                };
                await repository.AddAsync(userData);
            }
        }

        [Command]
        public virtual void onSignUpCancel()
        {

        }
    }
}
