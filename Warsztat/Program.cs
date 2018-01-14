using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public enum Marka { Opel, Skoda, Ford, Fiat }
    class Program
    {
        
        static void Main(string[] args)
        {



            Warsztat.DodajDoLsty(Marka.Ford, "2", "1");
            Warsztat.DodajDoLsty(Marka.Fiat, "66", "2");
            Warsztat.DodajDoLsty(Marka.Fiat, "2", "2");
            Warsztat.DodajDoLsty(Marka.Fiat, "4", "2");
            Warsztat.DodajDoLsty(Marka.Fiat, "2", "3");
            Warsztat.DodajDoLsty(Marka.Fiat, "6", "df3");
            Warsztat.DodajDoLsty(Marka.Fiat, "7", "dfdffddf");
            Warsztat.DodajDoLsty(Marka.Fiat, "8", "dfdffdddf");
            Warsztat.DodajDoLsty(Marka.Fiat, "9", "dfdffddf");
            Warsztat.DodajDoLsty(Marka.Fiat, "10", "dfdffddf");
            Warsztat.wypisz();

            Warsztat.DrugaUsterka("66", "kupa");
            
            Console.WriteLine();
            Warsztat.wypisz();
            Console.ReadKey();
            
        }
    }
}
