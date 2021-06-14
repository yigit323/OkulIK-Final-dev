using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulIK
{
    public class Enumlar
    {
        public enum Bolumler
        {

            BilgisayarProgramciligi = 0,
            BilgisayarMuhendisligi = 1,
            MakineMuhendisligi = 2
        
        }

        public enum Departman
        {
            Yonetim = 0,
            Uretim = 1,
            Reklam = 2,
            Muhasebe = 3,
            InsanKaynaklari = 4
        }
        
        public enum Gorevi
        {
            DisiplinKontrol = 0,
            PuantajKontrol = 1,
            PersonelKontrol = 2

        }
        

    }
}
