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
            var t = Student.Alice;
            Student st = new Student();

            Console.WriteLine(   BasicLessonEnum.Exeptions);
            Console.WriteLine((int)BasicLessonEnum.Exeptions);
            Console.WriteLine(BasicLessonEnum.Classes);
            Console.WriteLine((int)BasicLessonEnum.Classes);
        }


    }
}

