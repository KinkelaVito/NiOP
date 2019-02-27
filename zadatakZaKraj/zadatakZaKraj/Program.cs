using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadatakZaKraj.NewFolder1;

namespace zadatakZaKraj
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo voz1 = new Vozilo();
            Vozilo voz2 = new Vozilo();

            int brojac = 0;

            do
            {
                Console.WriteLine("Koje je vozilo vrste: ");
                voz1.Vrsta = Console.ReadLine();

                Console.WriteLine("Koja je maksimalna brzina vaseg vozila? ");
                voz1.MaxBrzina = double.Parse(Console.ReadLine());

                Console.WriteLine("Koliko kotaca ima? (ako nema upisite 0)");
                voz1.BrojKotaca = int.Parse(Console.ReadLine());

                brojac++;
            }
            while (brojac < 1);

            do
            {
                Console.WriteLine("Koje je vozilo vrste: ");
                voz2.Vrsta = Console.ReadLine();

                Console.WriteLine("Koja je maksimalna brzina vaseg vozila? ");
                voz2.MaxBrzina = int.Parse(Console.ReadLine());

                Console.WriteLine("Koliko kotaca ima? (ako nema upisite 0)");
                voz2.BrojKotaca = int.Parse(Console.ReadLine());

                brojac++;
            }
            while (brojac < 1);
 if (voz1.Vrsta == "Auto" || voz1.Vrsta == "auto")
            {
                voz1.MaxBrzina = voz1.MaxBrzina * 1.3;
            }

            Console.WriteLine(voz1.ispis());
            Console.WriteLine(voz2.ispis());


            

           

            Console.ReadKey();
        }
    }
}
