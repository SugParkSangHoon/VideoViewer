using MultiWindowTest.Bases;
using MultiWindowTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MultiWindowTest.ViewModels
{  
    public class MainWindowViewModel : ViewModelBase
    {
        private string? _title = "Prisim";   
        public string Title
        {
            get { return _title = "Prisim"; }
            set { SetProperty(ref _title, value); }
        }
        private readonly IView _view;
        public MainWindowViewModel(IView view)
        {
            this._view = view;
            ShowWindow = new RelayCommand(ExcuteMethod, CanExcuteMoethod);
        }

        private bool CanExcuteMoethod(object obj)
        {
            return true;
        }

        private void ExcuteMethod(object obj)
        {
            _view.Open();
        }
        #region MyCommand Command

        /// <summary>
        /// myCommand
        /// </summary>

        /// <summary>
        /// Get MyCommand
        /// </summary>
        public ICommand ShowWindow { get; set; }    
        #endregion

    }
}
