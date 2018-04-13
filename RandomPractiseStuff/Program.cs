using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractiseStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Singleton.Instance.Msg("!");

            FakturaRecepti fakturaRecepti = new FakturaRecepti();
            UslugaIzdavanjaDecorator uslugaIzdavanja = new UslugaIzdavanjaDecorator(fakturaRecepti);
            UslugaRastvaranjaDecorator uslugaRastvaranja = new UslugaRastvaranjaDecorator(uslugaIzdavanja);




            Console.WriteLine(uslugaRastvaranja.IznosFakture());
            Console.ReadLine();
        }
    }
}
