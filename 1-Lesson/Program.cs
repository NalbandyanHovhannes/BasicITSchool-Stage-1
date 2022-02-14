using System; 

namespace _1_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal u = 5;
            var t = Math.Abs(u);
            
            Console.WriteLine();
            //Console.WriteLine("Hellooooo");

            //Console.Write("WriteVS");

            //Console.WriteLine("Writeline");
            //Console.WriteLine("1");
            //Console.ReadLine();
            //Console.Read();

            //Console.WriteLine("Hello World!");
            //Console.Write("Hello World!");
            //Console.ReadLine();
            //Console.Read();
           
            Console.ReadKey();
            
           // Console.Write(true);

            var name = Console.ReadLine();
            Console.WriteLine("");
            var number2 = Console.ReadLine();

            Console.WriteLine("number1+number2={0}", name + number2);

            int x = Console.Read();
            Console.WriteLine(x);

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Thanks for press Enter");
            }

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
