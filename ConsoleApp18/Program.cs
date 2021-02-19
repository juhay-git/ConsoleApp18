using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            String nimi;
            String numero;

            Ajanottaja kello = new Ajanottaja();

            while(true)
            {
                Console.Write("Anna kilpailijan nimi (e lopettaa): ");
                nimi = Console.ReadLine();

                if (nimi == "e") break;

                Console.Write("Anna kilpailijan numero: ");
                numero = Console.ReadLine();

                Kilpailija k = new Kilpailija(nimi, numero);
                kello.LisaaKilpailija(k);
            }

            Console.Write("\nAloita kilpailu painamalla <enter>:");
            Console.ReadLine();

            kello.AloitaAjanotto();
            Console.Write("\nKilpailu käynnissä..\n\n");

            while(true)
            {
                Console.Write("Anna maaliin tulleen kilpailijan numero (e lopettaa): ");
                numero = Console.ReadLine();

                if (numero != "e")
                {
                    if (int.TryParse(numero, out _)) kello.pysaytaKilpailijanAjanotto(numero);
                    else Console.WriteLine("Anna kilpailijanumero");
                }
                else break;
            }

            Console.WriteLine();

            kello.tulostaTulokset();

            Console.ReadLine();
        }
    }
}
