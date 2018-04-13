using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractiseStuff
{
    public class DecoratorPattern
    {
    }

    public abstract class Faktura
    {
        public abstract decimal IznosFakture();
        public  decimal IznosPDV()
        {
            return Decimal.Round(IznosFakture() * 17 / 100, 2);
        }
        public  decimal iznosBezPDV()
        {
            return Decimal.Round(IznosFakture() /117 * 100, 2);
        }
    }


    public class FakturaRecepti : Faktura
    {
        public override decimal IznosFakture()
        {
            // artikl * placa_osiguranje

            return 300.43M;
        }
    }

    public class FakturaVIrman : Faktura
    {
        public override decimal IznosFakture()
        {
            //artikl * prodajna_cijena

            return 895.22M;
        }
    }


    public abstract class FakturaDecorator : Faktura
    {
        protected Faktura f;

        protected decimal d_iznosFakture;


        protected FakturaDecorator(Faktura faktura)
        {
            f = faktura;
        }

        public override decimal IznosFakture()
        {
            return d_iznosFakture + f.IznosFakture();
        }


    }


    public  class UslugaIzdavanjaDecorator : FakturaDecorator
    {
        //switch statement gdje vraca cijenu izdavanja u zavisnosti da li je verzija RS, Brcko, Tuzla
        private decimal cijena_izdavanja = 1.43M;

       
        public UslugaIzdavanjaDecorator(Faktura f) : base(f)
        {
            this.d_iznosFakture =  IznosIzdavanja();
        }

        public decimal IznosIzdavanja()
        {
            //cijena izdavanja * broj recepata
            return cijena_izdavanja * 50;
        }
        public decimal PdvUslugaIzdavanja()
        {
            return Decimal.Round(IznosIzdavanja() * 17 / 100, 2);
        }
        public decimal UslugaIzdavanjabezPDV()
        {
             return Decimal.Round(IznosFakture() /117 * 100, 2);
        }
    }

    public class UslugaRastvaranjaDecorator : FakturaDecorator
    {
        private decimal cijena_rastvaranja = 1.10M;

        public UslugaRastvaranjaDecorator(Faktura f ): base(f)
        {
            this.d_iznosFakture = IznosRastvaranja();
        }

        public decimal IznosRastvaranja()
        {
            return cijena_rastvaranja * 2;
        }


    }

    public class MarkiceDecorator : FakturaDecorator
    {

        // cijena markice itd itd


        public MarkiceDecorator(Faktura f) : base(f)
        {
            this.d_iznosFakture = IznosMarkice();
        }

        public decimal IznosMarkice()
        {
            return 30.55M;
        }
    }



 



}
