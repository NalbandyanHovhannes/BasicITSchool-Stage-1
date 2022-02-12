using System;

namespace _1_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Hello World!");
            Console.ReadLine();
            Console.Read();
            
            Console.ReadKey();
            Console.Write(true);
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();
            Console.WriteLine("number1+number2={0}",number1+number2);

            int x = Console.Read();
            Console.WriteLine(x);

            Console.WriteLine("Input A=");
            Console.Read();
            Console.ReadLine();
            Console.WriteLine("Input A=");
            Console.Read();

            Console.Write("Input tt=");
            Console.WriteLine("A+B=");

        }
    }
}
