using Newtonsoft.Json.Linq;
using System.IO;
using System.Reflection;

namespace DataAccessLayer
{
    public class Seeder
    {
        private string GetEmbeddedResourceAsString(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            // var names = assembly.GetManifestResourceNames();

            string result;
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
        public void seedMjesta()
        {
            using (var ctx = new cslaEFmodelContainer())
            {
                var mjestaJsonAll =
                GetEmbeddedResourceAsString("DataAccessLayer.SeedData.mjesta.json");

                JArray jsonValSpeakers = JArray.Parse(mjestaJsonAll) as JArray;
                dynamic mjs = jsonValSpeakers;
                foreach (dynamic m in mjs)
                {
                    ctx.Mjestas.Add(new Mjesta
                    {
                        Id = m.ID,
                        nazivMjesta = m.mjesta_grad
                    });
                    ctx.SaveChanges();

                }
            }
        }
        public void seedFond()
        {
            using (var ctx = new cslaEFmodelContainer())
            {
                var FondJsonAll =
                GetEmbeddedResourceAsString("DataAccessLayer.SeedData.Fond.json");

                JArray jsonValSpeakers = JArray.Parse(FondJsonAll) as JArray;
                dynamic mjs = jsonValSpeakers;
                foreach (dynamic m in mjs)
                {
                    ctx.Fonds.Add(new Fond
                    {
                        Id = m.Id,
                        sifraFond = m.sifra_fond,
                        nazivFond = m.naziv_lijek,
                        Aktivan = m.aktivan
                        
                    });
                    ctx.SaveChanges();

                }
            }
        }






    }
}
