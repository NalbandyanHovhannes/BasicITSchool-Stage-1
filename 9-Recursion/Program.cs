using System;

namespace _9_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var fbon = Fibonachi(70);// 1rst method fibonachi without recursion
            Console.WriteLine(fbon);

            Console.Write(NthFibonacciNumber(80));//2 nd wit recursion
            Console.ReadKey();

            var t = factorial(80);
            Console.WriteLine(t);
            Console.ReadKey();
        }

        public static int NthFibonacciNumber(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
            }
        }
        public static long Fibonachi(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;
            //if (n == 0) return 0; //return the first  number   
            //if (n == 1) return 1; //return the second  number 

            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
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

