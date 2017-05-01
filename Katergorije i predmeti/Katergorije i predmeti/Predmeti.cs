using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katergorije_i_predmeti
{
   public class Predmeti
    {
        public String naziv {get;set;}
        public int ECTS { get; set; }
        public Kategorija kategorija { get; set; }

        public Predmeti(String Naziv, int ECTS, Kategorija Kategorija) {


            this.ECTS = ECTS;
            this.kategorija = Kategorija;
            this.naziv = Naziv;


        }
    }
}
