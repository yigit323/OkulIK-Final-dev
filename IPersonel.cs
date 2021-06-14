using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulIK.Interface
{
    interface IPersonel
    {
        public int KimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarih { get; set; }
        public Enumlar.Departman Departman { get; set; }
        public Enumlar.Gorevi Gorev { get; set; }
        public DateTime BaslamaTarih { get; set; }
    }
}
