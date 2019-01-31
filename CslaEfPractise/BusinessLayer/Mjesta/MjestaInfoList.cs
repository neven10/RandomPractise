using Csla;
using Csla.Data.EF6;
using DataAccessLayer;
using System;


namespace BusinessLayer
{
    [Serializable]
    public class MjestaInfoList : ReadOnlyListBase<MjestaInfoList, MjestaInfo>
    {
        public static MjestaInfoList GetMjestaInfoList()
        {
            return DataPortal.Fetch<MjestaInfoList>();
        }

        private void DataPortal_Fetch()
        {
            RaiseListChangedEvents = false;
            IsReadOnly = false;
            using (var ctx = DbContextManager<cslaEFmodelContainer>.GetManager())
            {
                foreach (var item in Mjesta.GetMjesta())
                {
                    this.Add(MjestaInfo.GetMjestaInfo(item));
                }
            }
            IsReadOnly = false;
            RaiseListChangedEvents = true;
        }

    }
}
