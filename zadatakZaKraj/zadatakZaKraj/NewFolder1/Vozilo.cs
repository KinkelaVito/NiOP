using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatakZaKraj.NewFolder1
{
    class Vozilo
    {
        string vrsta;
        double maxBrzina;
        int brojKotaca;

        public string Vrsta { get => vrsta; set => vrsta = value; }
        public double MaxBrzina { get => maxBrzina; set => maxBrzina = value; }
        public int BrojKotaca { get => brojKotaca; set => brojKotaca = value; }

        public Vozilo(string vrsta, int maxBrzina, int brojKotaca)
        {
            this.vrsta = vrsta;
            this.maxBrzina = maxBrzina;
            this.brojKotaca = brojKotaca;
        }

        public string ispis()
        {
            return "Vrsta: " + vrsta +
                "\nMaxsimalna brzina: " + maxBrzina +
                "\nBroj kotaca: " + brojKotaca;
        }

        public Vozilo()
        {

        }


    }   
}
