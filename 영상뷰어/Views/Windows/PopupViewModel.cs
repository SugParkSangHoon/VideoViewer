﻿using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Base;
using 영상뷰어.Interfaces;

namespace 영상뷰어.Views.Windows
{
    public class PopupViewModel : PopupDialogViewModelBase
    {
        public ViewModelBase? PopupVM { get; set; }
        
        //private IContext _context;

        //public IContext Context
        //{
        //	get => _context;
        //	set => SetProperty(ref _context, value, "Context");
        //}
        
	}
}
