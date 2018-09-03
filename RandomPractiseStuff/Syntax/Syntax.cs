using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractiseStuff.Syntax
{
    class Syntax
    {

        void SplitSyntax()
        {
            string s = "Test test";
            string[] sarray = s.Split(' ');
            foreach (var v in sarray)
            {
                Console.WriteLine($"<{v}>");
            }
        }


        void TernaryOperator()
        {
            bool check = true;

            Console.Write((check) ? "It's checked" : "It's not checked");

            //cmd.Parameters.Add("@artiklpred", MySqlDbType.Bit).Value = (check) ? 1 : 0;

        }

        void NullCoalesce()
        {
            string mystring = null;
            Console.Write(mystring ?? "String is null");
        }

        void Dictionary()
        {

            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },

            //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }

            //};
            //return View("Index", products.Keys);
        }











    }
}
