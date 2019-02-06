using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinkelaVito06_02_2019.Klase;

namespace KinkelaVito06_02_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo avion = new Vozilo();

            avion.setBrojKotaca(6);
            avion.setLeti(true);
            avion.setPlovi(false);
            avion.setVozi(true);
            avion.setVrsta("Cessna");
            avion.setOznaka("1312");

            Console.WriteLine(
                "Vrsta " + avion.getVrsta() +
                "\nOznaka: " + avion.getOznaka() +
                "\nBroj kotača: " + avion.getBrojKotaa() +
                "\nPlovi: " + avion.getPlovi() +
                "\nVozi: " + avion.getVozi() +
                "\nLeti: " + avion.getLeti() + "\n"
                );

            Vozilo kamojon = new Vozilo(8, false, false, true, "RI1987AR", "TAM");
            Console.WriteLine(kamojon.ToString());

            Console.ReadKey();
        }
    }
}
