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


        public void Izracun() {

            upisanaKategorija.Clear();

            foreach (var item in upisaniPredmeta)
            {bool n = false;
                foreach (var item1 in upisanaKategorija)
                {
                    
                    if (item.kategorija ==item1.kategorija )
                    {
                        item1.brojECTS = item1.brojECTS + item.ECTS;

                        n = true;
                    }

                   
                }

                if (!n)
                {
                    UpisanaKategorija up = new UpisanaKategorija(item.kategorija, item.ECTS);

                    upisanaKategorija.Add(up);
                    }
            }

        }

        public void dodajPredmet(Predmeti P) {

            popisPredmeta.Add(P);




        }




    }


   

}
