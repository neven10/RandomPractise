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
    public class LagerSerijaRok : BusinessBase<LagerSerijaRok>
    {

        public static readonly PropertyInfo<string> SerijaProperty = RegisterProperty<string>(c => c.Serija);
        public string Serija
        {
            get { return GetProperty(SerijaProperty); }
            set { SetProperty(SerijaProperty, value); }
        }

        public static readonly PropertyInfo<DateTime> RokProperty = RegisterProperty<DateTime>(c => c.Rok);
        public DateTime Rok
        {
            get { return GetProperty(RokProperty); }
            set { SetProperty(RokProperty, value); }
        }

        public static readonly PropertyInfo<int> kolicinaProperty = RegisterProperty<int>(c => c.kolicina);
        public int kolicina
        {
            get { return GetProperty(kolicinaProperty); }
            set { SetProperty(kolicinaProperty, value); }
        }





    }
}
