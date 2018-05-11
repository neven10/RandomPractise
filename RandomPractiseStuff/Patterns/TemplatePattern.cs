using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractiseStuff.Patterns
{
    public abstract class TemplatePattern
    {
        public abstract void Method1();
        public abstract void Method2();
        public void Method3()
        {
            
        }
        public void TemplateMethod()
        {
            Method1();
            Method2();
            Method3();
        }

    }

    public class C1 : TemplatePattern
    {
        public override void Method1()
        {
            throw new NotImplementedException();
        }

        public override void Method2()
        {
            throw new NotImplementedException();
        }
    }

    public class DoStuff
    {
        public DoStuff()
        {
            TemplatePattern a = new C1();
            a.TemplateMethod();
        }

    }


}
