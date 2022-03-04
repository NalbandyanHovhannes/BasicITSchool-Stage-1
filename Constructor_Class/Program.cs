using System;

namespace Constructor_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test1 = new TestClass();
            test1.t = 1;
            test1.Method(true);

            TestClass test2 = new TestClass(8, 8);//use his constructor
            TestClass test3 = new TestClass(true, 8);
            TestClass test4 = new TestClass(8,true);
            //string uu= gbr.stringTest;
            //Declare static class
           // TestStaticClass testStaticClass = new TestStaticClass();
             var y= TestStaticClass.o ;


            TestStaticClass.Method();
            //Console.WriteLine("Hello World!");
        }
    }
    public class TestClass
    {
        public int t ;
        private int b;//private
        public int a1;
        public int a2;
        public string stringTest { get; set; }
        public int MyProperty { get; set; }
        //------------
        private int TTT;
        public int propo;
        public int MyPropertys  {  get { return TTT; } set { TTT = value; }
        }
        //---------------------
        public string Method(bool isOK)
        {

            if (isOK == true)
            {
                return "Good Job";
            }
            return "Pashlo na Dno";
        }
        public TestClass()//deafult constructor
        {

        }
        public TestClass(int b, bool isOK)
        {
            this.b = b;
            Method(isOK);
        }
        //public TestClass(int b, bool isOK)
        //{
        //    this.b = b;
        //    Method(isOK);
        //}
        public TestClass(bool b, int isOK)
        {
            this.b = isOK;
            Method(b);
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
        public  static readonly   int o=9;
        public static string Method()
        {
            return "ok";
        }
        
        //~TestStaticClass
        //    { }
    }
}