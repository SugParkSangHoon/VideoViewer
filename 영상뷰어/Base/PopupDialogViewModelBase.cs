using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 영상뷰어.Base
{
    public class PopupDialogViewModelBase : ViewModelBase
    {
        private ViewModelBase? _popupVM;
        public ViewModelBase? PopupVM
        {
            get { return GetProperty(() => _popupVM); }
            set { SetProperty(() => _popupVM, value); }
        }
        private DelegateCommand? _closeCommand;
        public DelegateCommand? CloseCommand
        {
            get
            {
                return _closeCommand ??
                    (_closeCommand = new DelegateCommand(
                        () =>
                        {
                            PopupVM = null;
                        }));
            }
        }
        public virtual void Cleanup()
        {
            //Messenger.Default.S
        }
    }
}
