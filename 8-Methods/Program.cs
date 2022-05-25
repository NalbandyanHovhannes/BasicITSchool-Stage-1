using System;

namespace _8_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            int values;
            values = Sum(7, 9);

            //values = Sum(8, 9, 89);


            //A method is a block of code which only runs when it is called.
            //You can pass data, known as parameters, into a method.
            //Why use methods? To reuse code: define the code once, and use it many times.           
            //Methods are declared in a class, struct, or interface by specifying the
            //access level such as public or private, optional modifiers such as abstract
            //or sealed, the return value, the name of the method, and any method parameters.
            //These parts together are the signature of the method.





            MyMethod();

            MyMethods("Liam", 5);
            MyMethods("Jenny", 8);
            MyMethods("Anja", 31);


            // Liam is 5
            // Jenny is 8
            // Anja is 31


            //Default parameter setted
            UUU();

             void MyMethod(string country = "Norway")
            {
                Console.WriteLine(country);
            }

        }
    
         public static  int UUU()
        {

            return 7;
        }

    public static int Sum(int a, int b)
    {
        int sum = a + b;
        return sum;

    }
    public static string Sum(int a, int b, int c)
    {

        return (a * b * c).ToString();
    }
    public static void MyMethods(string fname, int age)
    {
        Console.WriteLine(fname + " is " + age);
    }

    static void MyMethods(int t, string tt)
    {
        Console.WriteLine("I just got executed!");
    }
        public Program()
        {

        }
    public static int Count(int t)
    {
        int c = 0;
        for (int i = 0; i < t; i++)
        {
            int mod = i % 2;
            if (mod == 0)
            {
                c++;
            }
        }

        return t;

    }

        //Method overloading system

        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }

        //static void Main(string[] args)
        //{
        //    int myNum1 = PlusMethodInt(8, 5);
        //    double myNum2 = PlusMethodDouble(4.3, 6.26);
        //    Console.WriteLine("Int: " + myNum1);
        //    Console.WriteLine("Double: " + myNum2);
        //}

        //
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static string PlusMethod(string x, int y)
        { return (x + y).ToString();}

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        //static void Main(string[] args)
        //{
        //    int myNum1 = PlusMethod(8, 5);
        //    double myNum2 = PlusMethod(4.3, 6.26);
        //    Console.WriteLine("Int: " + myNum1);
        //    Console.WriteLine("Double: " + myNum2);
        //}


    }
}
