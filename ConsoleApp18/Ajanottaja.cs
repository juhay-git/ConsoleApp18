using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp18
{
    public class Ajanottaja
    {
        private DateTime alkuaika;
        private List<Kilpailija> Kilpailijat = new List<Kilpailija>();

        public void LisaaKilpailija(Kilpailija k)
        {
            Kilpailijat.Add(k);
        }

        public void tulostaTulokset()
        {
            int i = 1;
            
            Kilpailijat.Sort();

            foreach(Kilpailija k in Kilpailijat)
            {
                Console.Write("{0}: ", i);
                k.TulostaTiedot();
                i++;
            }
        }

        public void AloitaAjanotto()
        {
            alkuaika = DateTime.Now;
        }

        public void pysaytaKilpailijanAjanotto(String numero)
        {
            Kilpailija k = Kilpailijat.Find(x => x.Numero.Equals(numero));
            if (k != null) k.Aika = (DateTime.Now - alkuaika).ToString();
        }

    }
}