using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFileExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "sample.txt", "sample1.TXT", "sample.test.pdf", "sample1.PDF", "sample.xml", "sample2.txt", "sample3.txt" };
            var egrp = arr.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                     .GroupBy(x => x, (ext, extCnt) => new
                     {
                         Extension = ext,
                         Count = extCnt.Count()
                     });

            foreach (var v in egrp)
                Console.WriteLine("{0} File(s) with {1} Extension ", v.Count, v.Extension);
            Console.ReadLine();

        }

        

    }
}
