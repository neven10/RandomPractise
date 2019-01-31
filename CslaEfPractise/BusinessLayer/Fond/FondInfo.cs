using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csla;
using Csla.Data.EF6;
using DataAccessLayer;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    [Serializable]
    public class FondInfo : ReadOnlyBase<FondInfo>
    {
        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(c => c.Id);
        public int Id
        {
            get { return GetProperty(IdProperty); }
            private set { LoadProperty(IdProperty, value); }
        }

        public static readonly PropertyInfo<string> sifraFondProperty = RegisterProperty<string>(c => c.sifraFond);
        public string sifraFond
        {
            get { return GetProperty(sifraFondProperty); }
            private set { LoadProperty(sifraFondProperty, value); }
        }

        public static readonly PropertyInfo<string> nazivFondProperty = RegisterProperty<string>(c => c.nazivFond);
        public string nazivFond
        {
            get { return GetProperty(nazivFondProperty); }
            private set { LoadProperty(nazivFondProperty, value); }
        }

        public static readonly PropertyInfo<bool> AktivanProperty = RegisterProperty<bool>(c => c.Aktivan);
        public bool Aktivan
        {
            get { return GetProperty(AktivanProperty); }
            private set { LoadProperty(AktivanProperty, value); }
        }



        public static FondInfo GetFondInfo(Fond fond)
        {
            return DataPortal.Fetch<FondInfo>(fond);
        }

        protected void DataPortal_Fetch(Fond fond)
        {
    
                Id = fond.Id;
                sifraFond = fond.sifraFond;
                nazivFond = fond.nazivFond;
                Aktivan = fond.Aktivan;
            

        }

    }
}
