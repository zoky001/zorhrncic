using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katergorije_i_predmeti
{
    public class Kategorija
    {
        public string Naziv { get; set; }
        public int IDKat { get; set; }


        public Kategorija(string Naziv, int ID) {
            this.IDKat = ID;
            this.Naziv = Naziv;


    }
  
            
            
            }

    
}
