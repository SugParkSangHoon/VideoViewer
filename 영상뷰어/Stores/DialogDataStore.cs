using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.enums;

namespace 영상뷰어.Stores
{
    internal class DialogDataStore
    {
        public eDialog DilaogType { get; set; }
        public string? ImageFilePath { get; set; }

    }
}
