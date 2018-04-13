using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RandomPractiseStuff
{
    public class Singleton
    {

        private static volatile Singleton _instance;
        private static object syncLock = new object();


        public static Singleton Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }

                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
                return _instance;
            }
        }
        public void Msg(string poruka)
        {
            Console.WriteLine(poruka);
            Console.ReadLine();
        }








    }
}
