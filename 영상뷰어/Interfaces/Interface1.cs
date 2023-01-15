﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 영상뷰어.Interfaces
{
    public interface IDialog
    {
        object DataContext { get; set; }
        void Show();
        bool? ShowDialog();
        void Close();
    }
    public interface IDialogContext
    {
        IDialog Dialog { get; set; }
    }
}
