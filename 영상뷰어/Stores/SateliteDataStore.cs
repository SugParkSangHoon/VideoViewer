using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Interfaces;

namespace 영상뷰어.Stores
{
    internal class SateliteDataStore : IDataStore
    {
        public string? ImageFilePath { get; set; }
    }
}
