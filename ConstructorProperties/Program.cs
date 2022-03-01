using System;

namespace ConstructorProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class TestClas
    {
        int tetsint = 8;
        public int TestMethod(int testvalue)
        {

            return testvalue;
        }
        public TestClas()
        {

        }
        //public TestClas()
        //{

        //}
        //public TestClas()
        //{

        //}
    }
    public /*static*/ class Fooo

    {
        public Fooo()
        {

        }
        public Fooo(int a)
        {
            this.a = a;
        }
        public int tested { get { return FirtsProp; } set { FirtsProp = 9; } }
        public static int FirtsProp { get; set; }

        private int prop1;

        public int Prop1
        {
            get { return prop1; }
            set { prop1 = value; }
        }
        public int Prop2
        {
            get { return prop1; }
        }

        public  int a;
        public static void Test1()
        {
            Console.WriteLine("Test1");//console is a static class and methods

        }

    }


}
