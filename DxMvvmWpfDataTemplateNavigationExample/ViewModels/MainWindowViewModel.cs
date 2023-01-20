using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;

namespace DxMvvmWpfDataTemplateNavigationExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel() 
        {

        }

        //public virtual string ViewName { get; set; }
        //public ICommand<string> NavigateCommand { get; private set; }

        private string _viewName;
        public string ViewName
        {
            get { return _viewName; }
            set { SetProperty(ref _viewName, value, "ViewName"); }
        }
        [Command]
        public  void Navigate(string viewName)
        { 
            ViewName = viewName; 
        }

    }
}
