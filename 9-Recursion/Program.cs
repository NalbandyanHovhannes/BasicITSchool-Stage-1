using System;

namespace _9_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
           var t= factorial(8);
            Console.WriteLine(t);
            Console.ReadKey();
        }
        public static int factorial(int i)
        {
            int result;

            if (i == 1)
                return 1;
            result = factorial(i - 1) * i;
            return result;
        }
    }
}
