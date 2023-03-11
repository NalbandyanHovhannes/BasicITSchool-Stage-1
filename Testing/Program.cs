using System;
using System.Security.Cryptography.X509Certificates;
using Testing;
using static Testing.TestClass;

namespace Struct3
{
    class Program
    {
        public static int  Sum(int x)
        {
            int gum = 0;
            if (x==1)
            {
                return 1;
            }
            return x + Sum(x - 1);      }
        static void Main()


        { int k;
            long l = 200l;
            Console.WriteLine(Sum(100));
            // int array3 = new Array[];
            //int k;
            TestClass test= new TestClass();
            test.Adding( 9);
            Console.WriteLine(test.tt);//tpelua tt deafult arjecqn


            TestClass test2 = new TestClass(3,6,4);// public TestClass(int a,int b,int tt)
            Console.WriteLine(Test.one);
            var p=Test.one;
           // Console.WriteLine(one);

           

        }
        public enum Test
        {
            one, two, three, four, five
        }
     
    }
}
