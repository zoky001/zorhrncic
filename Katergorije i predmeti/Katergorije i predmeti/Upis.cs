using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katergorije_i_predmeti
{
    public class Upis
    {

        public List<Kategorija> popisKategorija = new List<Kategorija> { };
        public List<Predmeti> popisPredmeta = new List<Predmeti> { };

        public List<Predmeti> upisaniPredmeta = new List<Predmeti> { };

        public List<UpisanaKategorija> upisanaKategorija = new List<UpisanaKategorija> { };

        public Upis() {

            Kategorija k1 = new Kategorija("Znanost", 1);
            popisKategorija.Add(k1);


            Kategorija k2 = new Kategorija("Prioroda", 2);
            popisKategorija.Add(k2);

            Kategorija k3 = new Kategorija("Znanost i informatika", 1);
            popisKategorija.Add(k3);



        }

        public void dodajPredmet(Predmeti P) {

            popisPredmeta.Add(P);




        }




    }


   

}
