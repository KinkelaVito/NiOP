using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinkelaVito06_02_2019.Klase
{
    class Vozilo
    {
        int brojKotaca;
        bool vozi, leti, plovi;
        string vrsta, oznaka;

        public void setBrojKotaca(int brojKotacaPublic)
        {
            this.brojKotaca = brojKotacaPublic;
        }
        public int getBrojKotaa()
        {
            return this.brojKotaca;
        }

        public void setLeti(bool letiP)
        {
            this.leti = letiP;
        }
        public bool getLeti()
        {
            return this.leti;
        }

        public void setVozi(bool voziP)
        {
            this.vozi = voziP;
        }
        public bool getVozi()
        {
            return this.vozi;
        }

        public void setPlovi(bool PloviP)
        {
            this.plovi = PloviP;
        }
        public bool getPlovi()
        {
            return this.plovi;
        }

        public void setVrsta(string vrstaP)
        {
            this.vrsta = vrstaP;
        }
        public string getVrsta()
        {
            return this.vrsta;
        }

        public void setOznaka(string oznakaP)
        {
            this.oznaka = oznakaP;
        }
        public string getOznaka()
        {
            return this.oznaka;
        }

        public Vozilo(int brojKotaca, bool leti, bool plovi, bool vozi, string oznaka, string vrsta)
        {
            this.brojKotaca = brojKotaca;
            this.leti = leti;
            this.vozi = vozi;
            this.plovi = plovi;
            this.vrsta = vrsta;
            this.oznaka = oznaka;
        }

        public Vozilo()
        {

        }

        public override string ToString()
        {
            return "Vrsta: " + vrsta + "\nOznaka: " + oznaka + "\nPliva: " + plovi + 
                "\nVozi: " + vozi + "\nLeti: " + leti + "\nBroj kotača: " + +brojKotaca;

        }
    }
}
