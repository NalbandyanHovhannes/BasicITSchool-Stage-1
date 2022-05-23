using System;

namespace _9_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fbon = Fibonachi(70);// 1rst method fibonachi without recursion
            //Console.WriteLine(fbon);

            //Console.Write(NthFibonacciNumber(80));//2 nd wit recursion
            //Console.ReadKey();

            Fac(4);
            Console.WriteLine(Factorial(6));
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
        //    //if (n == 0) return 0; //return the first  number   
        //    //if (n == 1) return 1; //return the second  number 

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
            return mult;// mult=multiple
        
        }
        public static int Fac(int i) //5
        {
            int t = 0;

            if (t >= i)
            {
                Console.WriteLine(t);
                return t;
            }
            else
            {
                t = i + Fac(i);
                i--;
                return t;
            }


        }

    }
}

