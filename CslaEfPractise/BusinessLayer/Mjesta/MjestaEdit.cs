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
    public class MjestaEdit : BusinessBase<MjestaEdit>
    {


        #region Property

        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(c => c.Id);
        public int Id
        {
            get { return GetProperty(IdProperty); }
            set { SetProperty(IdProperty, value); }
        }

        public static readonly PropertyInfo<string> nazivMjestoProperty = RegisterProperty<string>(c => c.nazivMjesto);
        public string nazivMjesto
        {
            get { return GetProperty(nazivMjestoProperty); }
            set { SetProperty(nazivMjestoProperty, value); }
        }

        #endregion

        #region Business Rules
        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();

            BusinessRules.AddRule(new Required(nazivMjestoProperty) { MessageText = "Polje {0} je obavezno" });
            BusinessRules.AddRule(new ToUpper(nazivMjestoProperty) { Priority = 1 });


        }
        #endregion

        #region Factory methods


        public static MjestaEdit CreateMjestaEdit()
        {
            return DataPortal.Create<MjestaEdit>();
        }

        public static MjestaEdit GetMjestaEdit(int id)
        {
            return DataPortal.Fetch<MjestaEdit>(id);
        }

        public static void DeleteMjestaEdit(int id)
        {
            DataPortal.Delete<MjestaEdit>(id);
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(Id);
        }

        #endregion
        #region Data Access

        private void DataPortal_Fetch(int Id)
        {
            var mjesta = Mjesta.GetMjestbyId(Id);
            using (BypassPropertyChecks)
            {
                Id = mjesta.Id;
                nazivMjesto = mjesta.nazivMjesta;
          
            }
            BusinessRules.CheckRules();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            using (var ctx = DbContextManager<cslaEFmodelContainer>.GetManager())
            {
                var mjesta = new Mjesta();
                InsertUpdate(mjesta);
                ctx.DbContext.Mjestas.Add(mjesta);
                ctx.DbContext.SaveChanges();

            }
        }

        private void InsertUpdate(Mjesta Mjesta)
        {
            using (BypassPropertyChecks)
            {
                Mjesta.Id = Id;
                Mjesta.nazivMjesta = nazivMjesto;
            }
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            using (var ctx = DbContextManager<cslaEFmodelContainer>.GetManager())
            {
                var mjesta = ctx.DbContext.Mjestas.SingleOrDefault(c => c.Id == Id);
                InsertUpdate(mjesta);

                ctx.DbContext.SaveChanges();
            }
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        private void DataPortal_Delete(int id)
        {
            using (var ctx = DbContextManager<cslaEFmodelContainer>.GetManager())
            {

                var mjesta = ctx.DbContext.Set<Mjesta>().Find(id);
                if (mjesta == null)
                    throw new InvalidOperationException("Greška");
                ctx.DbContext.Set<Mjesta>().Attach(mjesta);
                ctx.DbContext.Entry(mjesta).State = EntityState.Deleted;
                ctx.DbContext.SaveChanges();

            }

        }
        #endregion


    }
}
