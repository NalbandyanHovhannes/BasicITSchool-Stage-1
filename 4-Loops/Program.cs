using System;
using System.Text;


namespace _4_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //If Else Loop
            int a = 8;
            int b = 12;
            int max;

            if (a>b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            Console.WriteLine("max="+max);

             max = (a > b) ? max = a : max = b;
            //You can simply write:
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);


            //---------------------------------------------------------------------------
            //Switch Case

            int day = 4;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)

            //---------------------------------------------------------------------------------
            //Switch case with break operator

            int today = 4;
            switch (today)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            // Outputs "Looking forward to the Weekend."
            //continue
            //-------------------------------------------------------------------
            //DO WHile and While do
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //Do while
            int t = 0;
            do
            {
                Console.WriteLine(t);
                t++;
                //t = 0;
            }
            while (t < 5);


            //----------------------------------------------------------------------------------
            //For Loop
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }


            for (int k = 0; k <= 10; k = k + 2)
            {
                Console.WriteLine(k);
            }

            for (int r = 0; r <= 10;)
            {
                Console.WriteLine(r);
            }
            for (; ; )
            {
                Console.WriteLine("??");
            }


            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string item in cars)
            {
                Console.WriteLine(item);
            }



            //1.StringBulder
            // StringBuilder sb = new StringBuilder();

            //or

            // StringBuilder sb = new StringBuilder("its a stringbuilder");
           // StringBuilder stringBuilder = new StringBuilder();

            var sb = new StringBuilder("Название: ");
            Console.WriteLine(sb);   // Название: 
            Console.WriteLine($"Длина: {sb.Length}"); // 10
            Console.WriteLine($"Емкость: {sb.Capacity}"); // 16

            sb.Append(" Руководство");
            Console.WriteLine(sb);   // Название: Руководство
            Console.WriteLine($"Длина: {sb.Length}"); // 22
            Console.WriteLine($"Емкость: {sb.Capacity}"); // 32

            sb.Append(" по C#");
            Console.WriteLine(sb);   // Название: Руководство по C#
            Console.WriteLine($"Длина: {sb.Length}"); // 28
            Console.WriteLine($"Емкость: {sb.Capacity}"); // 32



            StringBuilder sbb = new StringBuilder("Hello World!");

            for (int intt = 0; intt < sb.Length; intt++)
                Console.Write(sb[intt]); // output: Hello World!
        }
    }
    
}
