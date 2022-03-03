using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Static_Class.t = 8;
            //cant declare static class object(instance)
            //Static_Class static_Class = new Static_Class();
            //
            Static_Class.Method1();
            Static_Class y = new Static_Class();
          

            //Static_Class.Method3(); its not visibel for class in Main ,its not public Method
        }
    }
    public  class Static_Class
    {
        //a must be static,because in static class all members must be static
        //public int a;

        public static int t;
        public static void Method1()
        {
            Console.WriteLine("good job");
        }


        //Method2 must be static,because in static class all members must be static
        //public void Method2()
        //{
        //    Console.WriteLine("");
        //}

        static void Method3()
        {
            Console.WriteLine("good job");
        }




    }
}
