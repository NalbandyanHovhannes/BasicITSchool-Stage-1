using System;

namespace Enums

{
    public class Program
    {
        static void Main(string[] args)
        {
            WeekDays days = new WeekDays();
            
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Friday);
            Console.ReadKey();        

        }


    }
}

