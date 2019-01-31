using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csla;
using Csla.Data.EF6;
using DataAccessLayer;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using Csla.Rules.CommonRules;

namespace BusinessLayer
{
    [Serializable]
    public class ArtiklEdit : BusinessBase<ArtiklEdit>
    {

        #region Property

    
        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(c => c.Id);
        public int Id
        {
            get { return GetProperty(IdProperty); }
            set { SetProperty(IdProperty, value); }
        }
        public static readonly PropertyInfo<int> sifraArtiklProperty = RegisterProperty<int>(c => c.sifraArtikl);
        [Display(Name = "Sifra Artikla")]
        public int sifraArtikl
        {
            get { return GetProperty(sifraArtiklProperty); }
            set { SetProperty(sifraArtiklProperty, value); }
        }
        public static readonly PropertyInfo<string> nazivArtiklProperty = RegisterProperty<string>(c => c.nazivArtikl);
        [Display(Name = "Naziv Artikla")]
        public string nazivArtikl
        {
            get { return GetProperty(nazivArtiklProperty); }
            set { SetProperty(nazivArtiklProperty, value); }
        }
        public static readonly PropertyInfo<int> sifraFondProperty = RegisterProperty<int>(c => c.sifraFond);
        public int sifraFond
        {
            get { return GetProperty(sifraFondProperty); }
            set { SetProperty(sifraFondProperty, value); }
        }
        #endregion


        #region Business Rules
        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
            BusinessRules.AddRule(new ToUpper(nazivArtiklProperty));
            BusinessRules.AddRule(new Required(sifraArtiklProperty) { MessageText = "Polje {0} je obavezno" });
            BusinessRules.AddRule(new Required(nazivArtiklProperty) { MessageText = "Polje {0} je obavezno" });

        }
        #endregion



        #region Factory Methods

        public static ArtiklEdit CreateArtiklEdit()
        {
            return DataPortal.Create<ArtiklEdit>();

        }
        public static ArtiklEdit GetArtiklEdit(int id)
        {
            return DataPortal.Fetch<ArtiklEdit>(id);
        }
        public static void DeleteArtiklEdit(int id)
        {
            DataPortal.Delete<ArtiklEdit>(id);
        }
        #endregion



        #region Data Access

     
        private void DataPortal_Fetch(int id)
        {
            var artikl = Artikl.GetArtiklById(id);
            using (BypassPropertyChecks)
            {
                id = artikl.Id;
                sifraArtikl = artikl.sifraArtikl;
                nazivArtikl = artikl.nazivArtikl;
                sifraFond = artikl.FondId;
            }
            BusinessRules.CheckRules();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            using (var ctx = DbContextManager<cslaEFmodelContainer>.GetManager())
            {
                var artikl = new Artikl();
                InsertUpdate(artikl);
                ctx.DbContext.Artikls.Add(artikl);
                ctx.DbContext.SaveChanges();

            }
        }

        private void InsertUpdate(Artikl artikl)
        {
            using (BypassPropertyChecks)
            {
                artikl.Id = Id;
                artikl.nazivArtikl = nazivArtikl;
                artikl.sifraArtikl = sifraArtikl;
                artikl.FondId = sifraFond;
            }
        }
        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            using (var ctx = DbContextManager<cslaEFmodelContainer>.GetManager())
            {
                var artikl = Artikl.GetArtiklById(Id);
                InsertUpdate(artikl);
                ctx.DbContext.SaveChanges();
            }
        }


        [Transactional(TransactionalTypes.TransactionScope)]
        private void DataPortal_Delete(int id)
        {
            using (var ctx = DbContextManager<cslaEFmodelContainer>.GetManager())
            {
                var artikl = ctx.DbContext.Set<Artikl>().Find(id);
                if (artikl == null)
                    throw new InvalidOperationException("Greska");
                ctx.DbContext.Set<Artikl>().Attach(artikl);
                ctx.DbContext.Entry(artikl).State = EntityState.Deleted;
                ctx.DbContext.SaveChanges();
            }
        }
        #endregion











    }
}
