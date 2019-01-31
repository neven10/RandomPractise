using Csla;
using Csla.Data.EF6;
using DataAccessLayer;
using System;

namespace BusinessLayer
{
    [Serializable]
    public class ArtiklInfoList : ReadOnlyListBase<ArtiklInfoList, ArtiklInfo>
    {

        public static ArtiklInfoList GetArtiklInfoList()
        {
            return DataPortal.Fetch<ArtiklInfoList>();
        }

        private void DataPortal_Fetch()
        {
            RaiseListChangedEvents = false;
            IsReadOnly = false;
            using (var ctx = DbContextManager<cslaEFmodelContainer>.GetManager())
            {
                foreach (var item in Artikl.GetArtikl())
                {
                    this.Add(ArtiklInfo.GetArtiklInfo(item));
                }
            }
            IsReadOnly = false;
            RaiseListChangedEvents = true;
        }


    }
}
