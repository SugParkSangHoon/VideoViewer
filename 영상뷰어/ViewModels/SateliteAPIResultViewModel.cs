using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using 영상뷰어.Models;

namespace 영상뷰어.ViewModels
{
    [POCOViewModel]
    public class SateliteAPIResultViewModel
    {        
        public virtual ObservableCollection<SatelliteAPIModel> SateliteItems { get; set; }
        public SateliteAPIResultViewModel()
        {
            Messenger.Default.Register<ObservableCollection<SatelliteAPIModel>>(this, ReceiveData);
        }

        private void ReceiveData(ObservableCollection<SatelliteAPIModel> obj)
        {
            SateliteItems = obj;
        }

        #region MyCommand Command

        /// <summary>
        /// myCommand
        /// </summary>
        private DelegateCommand myCommand = null;

        /// <summary>
        /// Get MyCommand
        /// </summary>
        public ICommand MyCommand
        {
            get
            {
                if (this.myCommand == null)
                {
                    this.myCommand = new DelegateCommand(() => this.OnMyCommand());
                }

                return this.myCommand;
            }
        }
        #endregion

        #region OnMyCommand
        /// <summary>
        /// execute OnMyCommand
        /// </summary>
        private void OnMyCommand()
        {
        }

        #endregion

    }
}
