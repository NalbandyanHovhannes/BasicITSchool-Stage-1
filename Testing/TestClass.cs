using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{

    public class TestClass
    {

        public int tt=8555;
       public int Adding (int b)
        { return tt + b; }

        public int Multy(int a, int b)
        { return a * b; }

        public TestClass()
        {

        }
        public TestClass(int a,int b,int t)
        {
            Multy(a, b);
            tt = t;
        }
    }
}
