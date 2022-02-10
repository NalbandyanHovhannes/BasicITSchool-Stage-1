using System;

namespace Enums

{
    public class Program
    {
        static void Main(string[] args)
        {
            DaysEnums days = new DaysEnums();
            
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Friday);
            Console.ReadKey();        

        }


    }
}

