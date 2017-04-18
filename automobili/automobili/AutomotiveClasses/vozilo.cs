using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automobili.AutomotiveClasses
{
    abstract class Vozilo
    {

        private List<Dio> montiraniDijelovi;
        public VIN idAutomobila; // kompozicija
        public String naziv { get; set; }
        public int status { get; set; }
        public int tezina { get; set; }
        public int visina { get; set; }
        public int duzina { get; set; }
        public int meduosovinskiRazmak { get; set; }
        public String gume { get; set; }
        public int co2 { get; set; }

        public Vozilo
    }
}
