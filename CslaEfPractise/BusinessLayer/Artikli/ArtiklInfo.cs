using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csla;
using DataAccessLayer;

namespace BusinessLayer
{
    [Serializable]
    public class ArtiklInfo : ReadOnlyBase<ArtiklInfo>
    {

        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(c => c.Id);
        public int Id
        {
            get { return GetProperty(IdProperty); }
            private set { LoadProperty(IdProperty, value); }
        }
        public static readonly PropertyInfo<int> sifraArtiklProperty = RegisterProperty<int>(c => c.sifraArtikl);
        public int sifraArtikl
        {
            get { return GetProperty(sifraArtiklProperty); }
            private set { LoadProperty(sifraArtiklProperty, value); }
        }
        public static readonly PropertyInfo<string> NazivArtiklProperty = RegisterProperty<string>(c => c.NazivArtikl);
        public string NazivArtikl
        {
            get { return GetProperty(NazivArtiklProperty); }
            private set { LoadProperty(NazivArtiklProperty, value); }
        }
        public static readonly PropertyInfo<int> SifraFondProperty = RegisterProperty<int>(c => c.SifraFond);
        public int SifraFond
        {
            get { return GetProperty(SifraFondProperty); }
            private set { LoadProperty(SifraFondProperty, value); }
        }

        public static ArtiklInfo GetArtiklInfo(Artikl artikl)
        {
            return DataPortal.Fetch<ArtiklInfo>(artikl);
        }
        protected void DataPortal_Fetch(Artikl artikl)
        {
            Id = artikl.Id;
            sifraArtikl = artikl.sifraArtikl;
            NazivArtikl = artikl.nazivArtikl;
            SifraFond = artikl.FondId;
        }



    }
}
