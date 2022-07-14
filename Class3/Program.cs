using System;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test_Class_1 test_Class_2 ;
            //test_Class_2.a = 8; you must Declare object (instance)
            //Test_Class_1 test_Class_2 = new Test_Class_1();
            Test_Class_1 instance101 = new Test_Class_1();
            Test_Class_1.a_static = 8;
            instance101.Method1();
            Test_Class_1.Method2();
            //test_Class_1.a_s
            //tatic;we cant call to that field because that field is static
            instance101.b = 9;
            instance101.Method1();
            //test_Class_1.Method2();we cant call to that method because that method is static
            instance101.Method3(8);
            instance101.Method4(88);
            // StaticClass.Method();

        }
    }
    public class Test_Class_1
    {
        private int a;
        public static int a_static;
        public int b { get; set; }
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
        public string Method4(int a)
        {
            int r;
            r = a;
            return "Hello" + r;
        }
        public Test_Class_1(int a)
        {
            this.a = a;
        }
        public Test_Class_1(int u, int po)
        {
            this.a = u;
        }
        public Test_Class_1()
        {

        }

        public Test_Class_1(int uy, int u)
        {
            this.a = uy;
        }
    }
}
