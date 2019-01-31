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
    public class LagerObicniEdit : BusinessBase<LagerObicniEdit>
    {
        public static readonly PropertyInfo<decimal> FakturnaCijenaProperty = RegisterProperty<decimal>(c => c.FakturnaCijena);
        public decimal FakturnaCijena
        {
            get { return GetProperty(FakturnaCijenaProperty); }
            set { SetProperty(FakturnaCijenaProperty, value); }
        }
        public static readonly PropertyInfo<decimal> ProdajnaCijenaProperty = RegisterProperty<decimal>(c => c.ProdajnaCijena);
        public decimal ProdajnaCijena
        {
            get { return GetProperty(ProdajnaCijenaProperty); }
            set { SetProperty(ProdajnaCijenaProperty, value); }
        }
        public static readonly PropertyInfo<int> KolUlazProperty = RegisterProperty<int>(c => c.KolUlaz);
        public int KolUlaz
        {
            get { return GetProperty(KolUlazProperty); }
            set { SetProperty(KolUlazProperty, value); }
        }
        public static readonly PropertyInfo<int> KolIzlazProperty = RegisterProperty<int>(c => c.KolIzlaz);
        public int KolIzlaz
        {
            get { return GetProperty(KolIzlazProperty); }
            set { SetProperty(KolIzlazProperty, value); }
        }

        public static readonly PropertyInfo<ArtiklInfoList> ArtiklInfoProperty = RegisterProperty<ArtiklInfoList>(p => p.Artikl, RelationshipTypes.LazyLoad);
        public ArtiklInfoList Artikl
        {
            get
            {
                if (!FieldManager.FieldExists(ArtiklInfoProperty))
                    LoadProperty<ArtiklInfoList>(ArtiklInfoProperty, new ArtiklInfoList());
                return GetProperty<ArtiklInfoList>(ArtiklInfoProperty);
            }
        }
    }
}
