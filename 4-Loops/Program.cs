using System;

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
        }
    }
}
