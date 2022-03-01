using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   public class Example
    {

        //Constructor
        //Property
        //Method
        //Field
        //Indexator
        //Event
        //Operators


        //Construc
        public Example(int y)
        {
            t = y;
        }

        //Property
        public int TestProperty { get; set; }


        //field
        int t;
        public int a;

        //field
        public static int b;

        //Method
        public void TestMethod()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }     


    }

}
