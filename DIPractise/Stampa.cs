using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskalnaStampaTest
{
    public class Stampa
    {
        Dokument _d;
        IMikroleketronikaStampac _m;
        IGalebStampac _g;
        IObicanStampac _o;

        public Stampa(Dokument d, IMikroleketronikaStampac m, IGalebStampac g, IObicanStampac o)
        {
            _d = d;
            _m = m;
            _g = g;
            _o = o;
        }

        public void Mikroeletronika(Dokument d)
        {
            this._m.Stampaj(d);
            this._m.OtvoriKasu();
            this._m.VratiOdgovor();
        }
        public void Galeb(Dokument d)
        {
            this._g.Stampaj(d);
            this._g.OtvoriKasu();

        }
        public void ObicanStampac(Dokument d)
        {
            this._o.Stampaj(d);
        }
    }

    public class Dokument
    {

    }

    public class StampaRepository : IMikroleketronikaStampac, IGalebStampac
    {
        public void NadjiPapir()
        {
            throw new NotImplementedException();
        }

        public void OtvoriKasu()
        {
            throw new NotImplementedException();
        }

        public void ResetArtikla()
        {
            throw new NotImplementedException();
        }

        public void Stampaj(object dok)
        {
            throw new NotImplementedException();
        }

        public void VratiOdgovor()
        {
            throw new NotImplementedException();
        }
    }

    public interface IObicanStampac : Stampac
    {

    }

    public interface IMikroleketronikaStampac : Stampac, FiskalniStampac
    {
        void VratiOdgovor();
    }
    public interface IGalebStampac : Stampac, FiskalniStampac
    {
        void ResetArtikla();
    }

    public interface ITermalniStampac : Stampac, FiskalniStampac
    {
        
    }
    public interface Stampac
    {
        void Stampaj(object dok);
    }
    public interface FiskalniStampac
    {
        void OtvoriKasu();
        void NadjiPapir();
    }



}