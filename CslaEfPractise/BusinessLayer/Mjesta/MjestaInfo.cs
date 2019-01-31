using Csla;
using Csla.Data.EF6;
using Csla.Rules.CommonRules;
using DataAccessLayer;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
namespace BusinessLayer
{
    [Serializable]
    public class MjestaInfo : ReadOnlyBase<MjestaInfo>
    {

        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(c => c.Id);
        public int Id
        {
            get { return GetProperty(IdProperty); }
            private set { LoadProperty(IdProperty, value); }
        }
        public static readonly PropertyInfo<string> nazivMjestoProperty = RegisterProperty<string>(c => c.nazivMjesto);
        public string nazivMjesto
        {
            get { return GetProperty(nazivMjestoProperty); }
            private set { LoadProperty(nazivMjestoProperty, value); }
        }

        public static MjestaInfo GetMjestaInfo(Mjesta mjesta)
        {
            return DataPortal.Fetch<MjestaInfo>(mjesta);
        }

        protected void DataPortal_Fetch(Mjesta mjesta)
        {

            Id = mjesta.Id;
            nazivMjesto = mjesta.nazivMjesta;
     


        }
    }
}
