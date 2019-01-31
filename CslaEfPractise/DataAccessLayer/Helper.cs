using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial class Fond
    {

        public static Fond GetFondById(int Id)
        {
            using (var ctx = new cslaEFmodelContainer())
            {
                var getfond = ctx.Fonds.FirstOrDefault(c => c.Id == Id);
                if (getfond != null)
                    return getfond;

                throw new InvalidOperationException("Greska");
            }
        }


      

        public static IEnumerable<Fond> GetFond()
        {

            using (var ctx = new cslaEFmodelContainer())
            {
                return ctx.Fonds.ToList();
            }

        }

    }
    public partial class Artikl
    {

        public static Artikl GetArtiklById(int Id)
        {
            using (var ctx = new cslaEFmodelContainer())
            {
                var artikl = ctx.Artikls.SingleOrDefault(c => c.Id == Id);

                if (artikl != null)
                    return artikl;

                throw new InvalidOperationException("Greska");
            }
        }

        public static IEnumerable<Artikl> GetArtikl()
        {

            using (var ctx = new cslaEFmodelContainer())
            {
                return ctx.Artikls.ToList();
            }

        }

    }
    public partial class Mjesta
    {
        public static Mjesta GetMjestbyId(int Id)
        {
            using (var ctx = new cslaEFmodelContainer())
            {
                var mjesta = ctx.Mjestas.SingleOrDefault(c => c.Id == Id);

                if (mjesta != null)
                    return mjesta;

                throw new InvalidOperationException("Greska");
            }
        }

        public static IEnumerable<Mjesta> GetMjesta()
        {

            using (var ctx = new cslaEFmodelContainer())
            {
                return ctx.Mjestas.ToList();
            }

        }

    }

}
