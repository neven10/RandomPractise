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
    public class FondEdit : BusinessBase<FondEdit>
    {


        #region Property

        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(c => c.Id);

        public int Id
        {
            get { return GetProperty(IdProperty); }
            set { SetProperty(IdProperty, value); }
        }

        public static readonly PropertyInfo<string> sifraFondProperty = RegisterProperty<string>(c => c.sifraFond); 
        [Display(Name = "Šifra fonda")]
        public string sifraFond
        {
            get { return GetProperty(sifraFondProperty); }
            set { SetProperty(sifraFondProperty, value); }
        }


        public static readonly PropertyInfo<string> nazivFondProperty = RegisterProperty<string>(c => c.nazivFond);
        [Display(Name = "Lijek")]
        public string nazivFond
        {
            get { return GetProperty(nazivFondProperty); }
            set { SetProperty(nazivFondProperty, value); }
        }

        public static readonly PropertyInfo<bool> AktivanProperty = RegisterProperty<bool>(c => c.Aktivan);
        public bool Aktivan
        {
            get { return GetProperty(AktivanProperty); }
            set { SetProperty(AktivanProperty, value); }
        }
        #endregion

        #region Business Rules
        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
            // Kako da napravim delegates za npr generic message "Polje je obavezno"  BusinessRules.AddRule(new Required(NameProperty) { MessageDelegate = () => Resources.???? }); 

            BusinessRules.AddRule(new Required(sifraFondProperty) { MessageText = "Polje {0} je obavezno" });
            BusinessRules.AddRule(new MaxLength(sifraFondProperty, 8) {MessageText = "{0} ne moze biti vece od 8 karaktera" });
            BusinessRules.AddRule(new Required(nazivFondProperty) { MessageText = "Polje {0} je obavezno" });
            BusinessRules.AddRule(new MinLength(nazivFondProperty, 3) { MessageText = "{0} ne moze biti manji od 3 karaktera" });
            BusinessRules.AddRule(new CapitalizeFirst(nazivFondProperty) { Priority = 1 });


        }
        #endregion
        
        #region Factory methods
        public static FondEdit CreateFondEdit()
        {
            return DataPortal.Create<FondEdit>();
        }
        public static FondEdit GetFondEdit(int Id)
        {
            return DataPortal.Fetch<FondEdit>(Id);
        }
        public static void DeleteFondEdit(int Id)
        {
            DataPortal.Delete<FondEdit>(Id);
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(Id);
        }



        #endregion

        #region Data Access

        private void DataPortal_Fetch(int Id)
        {
            var fond = Fond.GetFondById(Id);
            using (BypassPropertyChecks)
            {
                Id = fond.Id;
                sifraFond = fond.sifraFond;
                nazivFond = fond.nazivFond;
                Aktivan = fond.Aktivan;
            }
            BusinessRules.CheckRules();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            using (var ctx = DbContextManager<cslaEFmodelContainer>.GetManager())
            {
                var fond = new Fond();
                InsertUpdate(fond);
                ctx.DbContext.Fonds.Add(fond);
                ctx.DbContext.SaveChanges();

            }
        }

        private void InsertUpdate(Fond fond)
        {
            using (BypassPropertyChecks)
            {
                fond.Id = Id;
                fond.sifraFond = sifraFond;
                fond.nazivFond = nazivFond;
                fond.Aktivan = Aktivan;
            }
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            using (var ctx = DbContextManager<cslaEFmodelContainer>.GetManager())
            {
                var fond = ctx.DbContext.Fonds.SingleOrDefault(c => c.Id == Id);
                InsertUpdate(fond);
              
                ctx.DbContext.SaveChanges();
            }
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        private void DataPortal_Delete(int id)
        {
            using (var ctx = DbContextManager<cslaEFmodelContainer>.GetManager())
            {

                var fond = ctx.DbContext.Set<Fond>().Find(id);
                if (fond == null)
                    throw new InvalidOperationException("Greška");
                ctx.DbContext.Set<Fond>().Attach(fond);
                ctx.DbContext.Entry(fond).State = EntityState.Deleted;
                ctx.DbContext.SaveChanges();
   
            }

        }
        #endregion



    }
}
