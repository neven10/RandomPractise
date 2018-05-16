using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 5, 55, 565, 4, 849, 8494, 494, 53, 161, 43, 3, 3, };
            var d = new Dictionary<int, int>();
            foreach (var i in array)
            {
                if (!d.ContainsKey(i))
                {
                    d.Add(i, 0);
                }
                d[i]++;
            }

            foreach(var o in d)
            {
                Console.WriteLine("{0}, {1}", o.Key, o.Value);
            }
            Console.ReadLine();

            


        }

        
    }
}
