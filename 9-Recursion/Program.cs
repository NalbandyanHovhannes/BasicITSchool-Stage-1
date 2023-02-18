using System;

namespace _9_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var fbon = Fibonachi(15);*/// 1rst method fibonachi without recursion
                                     // Console.WriteLine(fbon);
                                     //Console.Write(NthFibonacciNumber(3));//2 nd with recursion
                                     //Console.ReadKey();
            Console.WriteLine(Factorial(6));
            //--------------------------------
            //var factor=Fac(6);
            Console.WriteLine(Factorial(60000));
            Console.ReadKey();            
        }

        //public static int NthFibonacciNumber(int n)
        //{
        //    if ((n == 0) || (n == 1))
        //    {
        //        return n;
        //    }
        //    else
        //    {
        //        return (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
        //    }
        //}
        //public static long Fibonachi(int n)
        //{
        //    int firstnumber = 0, secondnumber = 1, result = 0;
        //    if (n == 0) return 0; //return the first  number   
        //    if (n == 1) return 1; //return the second  number 

        //    for (int i = 2; i <= n; i++)
        //    {
        //        result = firstnumber + secondnumber;
        //        firstnumber = secondnumber;
        //        secondnumber = result;
        //    }
        //    return result;
        //}
        public static int Factorial(int i) //5
        {
            int mult;
            if (i == 1)
                return 1;           
            mult= i * Factorial(i - 1);
            return mult;// mult=multiplep        
        }
        public static int Fac(int r) //5
        {
            int sum=1;
            for (int i = 2; i <=r; i++)
            {
                sum = sum * i;                
            }
            return sum;

        }
    }
}

