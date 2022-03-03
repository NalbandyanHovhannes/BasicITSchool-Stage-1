using System;

namespace Struct3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStruct testStruct=new TestStruct();
            testStruct.b = 7;
            testStruct.Method1();
            testStruct.Method3(7);
           // testStruct.MyProperty{ };
            TestStruct testStruct_1;
            testStruct_1.a = 1;
            //testStruct_1.b = 7;  its error
            // testStruct_1.Method1(); Error
            //testStruct_1.Method3(7); error
            //testStruct_1.Method1();error Please Declare object kam instance
            //testStruct_1.Method3();error Please Declare object kam instance
            //testStruct_1.Method4(); error Please Declare object kam instance

        }
    }
    //We cant declare static struck
    //public static struct Test1
    //{ }
    public  struct TestStruct
    {
        public int a;
        public static int a_static;
        public int b { get; set; }//

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }//accesor
            set { myVar = value; }//mutator
        }

        public static int c;
        public void Method1()
        {
            Console.WriteLine(a);
        }
        public static void Method2()
        {
            Console.WriteLine(a_static);
        }
        public int Method3(int x)
        {
            return x * x;
        }
        public  string Method4(int a)
        {
            int r;
            r = a;
            return "Hello"+r;
        }
        //public TestStruct(int a_static = 8,int c = 7)
        //{
        //    this.b = 8;
        //    this.a = a_static;
        //    myVar = b;

        //}      
        //grel constructor
        //public TestStruct()
        //{

        //}
    }
}
