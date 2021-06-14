using OkulIK.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulIK
{
    public class Ogrenci : IOgrenci, IOgrenciDersler
    {
        public int OgrenciNo { get ; set ; }
        public string Ad { get ; set ; }
        public string Soyad { get ; set ; }
        public DateTime DogumTarih { get ; set ; }
        public Enumlar.Bolumler Bolum { get ; set ; }
        public string Sınıfı { get ; set ; }
        public int NotOrtalamasi { get ; set ; }
        public int DersNo { get; set; }
        IOgrenci IOgrenciDersler.OgrenciNo { get; set; }
    }
    

}

