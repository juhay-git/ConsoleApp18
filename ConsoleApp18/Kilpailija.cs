using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp18
{
    public class Kilpailija:IComparable<Kilpailija>
    {
        public String Nimi { get; set; }
        public String Numero { get; set; }
        public String Aika { get; set; }

        public Kilpailija(String nimi, String numero)
        {
            this.Nimi = nimi;
            this.Numero = numero;
        }

        public string PalautaTiedot()
        {
            return "Nimi: " + Nimi + "\tNumerot: " + Numero + "\tAika:" + Aika;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine("Nimi: {0}\tNumero: {1}\tAika: {2}", Nimi, Numero, Aika);
        }

        public int CompareTo(Kilpailija vertaile)
        {
            if (vertaile == null) 
                return 1;
            else 
                return this.Aika.CompareTo(vertaile.Aika);
        }
    }
}