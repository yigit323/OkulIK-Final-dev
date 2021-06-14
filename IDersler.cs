using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulIK.Interface
{
    interface IDersler
    {
        public int DersNo { get; set; }
        public string Ad { get; set; }
        public string Acıklama { get; set; }
        public IOgretimGorevlisi OgretimGorevlisi { get; set; }
    }
}
