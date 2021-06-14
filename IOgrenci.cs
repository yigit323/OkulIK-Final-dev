using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulIK.Interface
{
    interface IOgrenci
    {
        public int OgrenciNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarih { get; set; }
        public Enumlar.Bolumler Bolum { get; set; } 
        public string Sınıfı { get; set; }
        public int NotOrtalamasi { get; set; }


    }
}
