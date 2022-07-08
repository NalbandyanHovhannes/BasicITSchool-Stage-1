using System;
using System.Text;


namespace _4_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ////If Else Loop
            //int a = 8;
            //int b = 12;
            //int max;

            //if (a>b)
            //{
            //    max = a;
            //}
            //elsedxe
            //{
            //    max = b;
            //}
            //Console.WriteLine("max="+max);
            //max = 0;
            // max = (a > b) ?  a :  b;


            ////You can simply write:
            //int time = 20;
            //string result = (time < 18) ? "Good day." : "Good evening.";
            //Console.WriteLine(result);


            ////---------------------------------------------------------------------------
            ////Switch Case
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
            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    continue;

                }
                    Console.WriteLine(i);
            }
            //// Outputs "Thursday" (day 4)

            ////---------------------------------------------------------------------------------
            ////Switch case with break operator

            string today = "4";
            switch (today)
            {
                case "4":
                    Console.WriteLine("Davit");
                    break;
                case "8":
                    Console.WriteLine("Aram"); 
                    break;

                default:
                    Console.WriteLine("Missing number");
                    break;
            }
            //// Outputs "Looking forward to the Weekend."
            ////continue
            ////-------------------------------------------------------------------
            ////DO WHile and While do


            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            ////Do while
            //int t = 0;
            //do
            //{
            //    Console.WriteLine(t);
            //    t++;
            //    //t = 0;
            //}
            //while (t < 5);


            ////----------------------------------------------------------------------------------
            ////For Loop
            //for (int j = 0; j < 5; j++)
            //{
            //    Console.WriteLine(j);
            //}


            //for (int k = 0; k <= 10; k = k + 2)
            //{
            //    Console.WriteLine(k);
            //}

            //for (int r = 0; r <= 10;)
            //{
            //    Console.WriteLine(r);
            //}
            /*for (int tt=0;tt<10 ; )
          
            for (int c = 0; c < 7; c++)
            {
                if (c == 4)
                {
                    continue;
                }
                Console.WriteLine(c);
            }


            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //foreach (string item in cars)
            //{
            //    Console.WriteLine(item);
            //}



            
            //int j = 1;
            for (int i = 1, j = 1; i <=9; ++i)
            {
                Console.Write(i * j);
                if (i == 9)
                {
                    j++;
                    Console.WriteLine(); 
                    
                }
                if (j > 9)
                {
                    break;
                }
            }*/


            //TODO
            for (int i = 1; i < 10; i++)
            {                
                for (int j = 1;  j < 10;  j++)
                {
                    Console.WriteLine(i + "*" + j + " = " + i * j );
                }
                Console.WriteLine();
            }

            double result = 0;
            for (int i = 100; i < 1000; i++)
            {
                result = Math.Sqrt(i * 16);
                if (result % 1 == 0)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
    
}
