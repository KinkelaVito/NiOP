using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klaseAndObjekti.Klase;

namespace klaseAndObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo ime = new Vozilo();
            bool nastaviti = true;

            do
            {
                Console.WriteLine("Kojoj vrsti vozila pripada: ");
                ime.setVrsta(Console.ReadLine().ToString());

                Console.WriteLine("Koliko kotača ima (ako nema unesite 0): ");
                ime.setBrojKotaca(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Vozi li (true/false): ");
                ime.setVozi(bool.Parse(Console.ReadLine()));

                Console.WriteLine("Plovi li (true/false): ");
                ime.setPliva(bool.Parse(Console.ReadLine()));

                Console.WriteLine("Leti li (true/false): ");
                ime.setLeti(bool.Parse(Console.ReadLine()));

                Console.WriteLine("Koja je oznaka vozila:");
                ime.setOznaka(Console.ReadLine().ToString());

                Console.WriteLine(ime.ispis());

                Console.WriteLine("Nastavite upisivati vozila? (true/false)");
                nastaviti = bool.Parse(Console.ReadLine());
            }
            while (nastaviti == true);

            /*
            Vozilo kamijon = new Vozilo(8, false, false, true, "TAM", "RI1987AR");

            Console.WriteLine("Vrsta: " + avijon.getVrsta() + " Oznaka: " +
                avijon.getOznaka() + "\nLeti: " + avijon.getLeti() + "\nPlovi: "+ avijon.getPliva()
                + "\nVozi: " + avijon.getVozi() + "\nBroj kotača: "+avijon.getBrojKotaca() + "\n");

            Console.WriteLine(kamijon.ToString() + "\n");

            Console.WriteLine(avijon.ispis());
            */

            Console.ReadLine();
        }
    }

    
}
