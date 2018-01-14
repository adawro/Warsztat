using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public static class Warsztat
    {
        static public List<Samochod> samochody = new List<Samochod>();

        static public void DodajDoLsty(Marka marka, string rej, string usterka)
        {
            if (!samochody.Any(s => s.PobierzRejestracje() == rej && s.Marka != marka))
            samochody.Add(Samochod.StworzSamochod(marka, rej, usterka));
        }
        static public void WykonajNaprawe(int ile)
        {
            int i = 0;
            if (ile <= samochody.Count)
            {
                for (int j = samochody.Count - 1; j >= 0; j--)
                {
                    if (i < ile)
                    {
                        samochody.RemoveAt(j);
                        i++;
                    }
                    else break;
                }
            }

        }
        static public void WykonajNaprawe(string rej)
        {
            samochody.RemoveAll(samochody => samochody.PobierzRejestracje() == rej);
        }

        static public void DrugaUsterka(string rej, string nowaUsterka)
        {
            foreach (var e in samochody)
            {
                if(e.PobierzRejestracje()==rej)
                {
                    Samochod kopia = e.SkopiujSamochod();
                    kopia.ZmienUSterke(nowaUsterka);
                    samochody.Add(kopia);
                    break;
                }
            }
        }
            
        static public void wypisz()
        {
            foreach (var e in samochody)
            {
                Console.WriteLine("{0}, {1}, {2}",e.Rejestracja,e.Usterka,e.Marka);
            }
        }



    }
}
