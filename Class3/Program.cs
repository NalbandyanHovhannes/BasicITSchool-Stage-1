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
            Test_Class_1 test_Class_1=new  Test_Class_1(7);
            test_Class_1.a = 8;
            //test_Class_1.a_static;we cant call to that field because that field is static
            test_Class_1.b = 9;
            test_Class_1.Method1();
            //test_Class_1.Method2();we cant call to that method because that method is static
            test_Class_1.Method3(8);
            test_Class_1.Method4(88);

        }
    }
    public class Test_Class_1
    {
        public int a;
        public static int a_static;
        public int b { get; set; }

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

    }
}
