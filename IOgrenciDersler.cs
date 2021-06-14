using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulIK.Interface
{
    interface IOgrenciDersler
    {
        public int DersNo { get; set; }
        public IOgrenci OgrenciNo { get; set; }
        
    }
}
