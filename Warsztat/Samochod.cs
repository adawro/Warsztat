using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    
   public class Samochod
    {
        private Marka marka;
        private string rejestracja;
        private string usterka;

        public Marka Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Usterka
        {
            get { return usterka; }
            set { usterka = value; }
        }
        public string Rejestracja       
        {
            get { return rejestracja; }
            set { rejestracja = value; }
        }

        public Samochod(Marka marka, string rejestracja, string usterka) // z private na public na chwile 
        {
            this.marka = marka;
            this.rejestracja = rejestracja;
            this.usterka = usterka;


        }
        //kurwa ja pierdole nie robcie tego fchuj
        public static  Samochod StworzSamochod(Marka marka, string rejestracja, string usterka)
        {
            Samochod samochod = new Samochod(marka, rejestracja, usterka);
            return samochod;
        }

        public string PobierzRejestracje()
        {
            return rejestracja;
        }
        public void ZmienUSterke(string usterka)
        {
            this.usterka = usterka;
        }
        public Samochod SkopiujSamochod()
        {
            Samochod tempSamochod = new Samochod(marka,rejestracja,usterka);
            tempSamochod.rejestracja = this.rejestracja;
            tempSamochod.usterka = this.usterka;
            tempSamochod.marka = this.marka;
            return tempSamochod;
        }

        
    }
}
