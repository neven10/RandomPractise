using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csla;
using Csla.Data.EF6;
using DataAccessLayer;

namespace BusinessLayer
{
    [Serializable]
    public class FondInfoList : ReadOnlyListBase<FondInfoList, FondInfo>
    {
        public static FondInfoList GetFondInfoList()
        {
            return DataPortal.Fetch<FondInfoList>();
        }

        private void DataPortal_Fetch()
        {
            RaiseListChangedEvents = false;
            IsReadOnly = false;
            using (var ctx = DbContextManager<cslaEFmodelContainer>.GetManager())
            {
                foreach (var item in Fond.GetFond())
                {
                    this.Add(FondInfo.GetFondInfo(item));
                }
            }
            IsReadOnly = false;
            RaiseListChangedEvents = true;
        }
    }
}
