using System;

namespace Constructor_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test1 = new TestClass();
            TestClass test2 = new TestClass(8, 8);//use his constructor
            TestClass test3 = new TestClass(8, true);

            //Declare static class
            //TestStaticClass testStaticClass = new TestStaticClass();
            TestStaticClass.o = 9;
            TestStaticClass.Method();
            //Console.WriteLine("Hello World!");
        }
    }
    public class TestClass
    {
        public int t = 1;
        private int b;
        public int a1;
        public int a2;
        public string stringTest { get; set; }
        public string Method(bool isOK)
        {

            if (isOK == true)
            {
                return "Good Job";
            }
            return "Pashlo na Dno";
        }
        public TestClass()
        {

        }
        public TestClass(int b, bool isOK)
        {
            this.b = b;
            Method(isOK);
        }
        public TestClass(int a1, int a3)
        {
            this.a1 = a1;
            a2 = a3;
        }

        //Destructor declare syntax
        ~TestClass()
        {
            System.Diagnostics.Trace.WriteLine("First's finalizer Started");

        }

    }

    public static class TestStaticClass
    {
        public static int o;
        public static string Method()
        {
            return "ok";
        }
        //public TestStaticClass(int t)
        //{
        //    this.o = t;
        //}
        //~TestStaticClass
        //    { }
    }
}