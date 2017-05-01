using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katergorije_i_predmeti
{
    public class UpisanaKategorija
    {
        public Kategorija kategorija { get; set; }
        public int brojECTS { get; set; }
        public UpisanaKategorija(Kategorija k, int ec) {

            this.kategorija = k;
            this.brojECTS = ec;

        }
    }



    
}
