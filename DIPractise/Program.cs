using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using FiskalnaStampaTest;

namespace DIPractise
{
    class Program
    {
        private Dokument d = new Dokument();
        IContainer c;

        public static void Main(string[] args)
        {
         
        }

        public  void Initialize()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<Stampa>().As<Stampa>();
            builder.RegisterType<StampaRepository>().As<IMikroleketronikaStampac>();
            builder.RegisterType<StampaRepository>().As<IGalebStampac>();
            builder.RegisterType<StampaRepository>().As<ITermalniStampac>();
            builder.RegisterType<StampaRepository>().As<IObicanStampac>();
            c = builder.Build();
        }

        public void ObicnaStampa()
        {
            var stampac = c.Resolve<IObicanStampac>();
            stampac.Stampaj(d);

        }

        public void TestEvent()
        {
            
            var mikroelektronika = c.Resolve<IMikroleketronikaStampac>();
            mikroelektronika.OtvoriKasu();
            mikroelektronika.Stampaj(d);
            mikroelektronika.VratiOdgovor();
        }

        public void TestEvent2()
        {
 
            var galeb = c.Resolve<IGalebStampac>();
            galeb.OtvoriKasu();
            galeb.Stampaj(d);
            
        }




    }
}
