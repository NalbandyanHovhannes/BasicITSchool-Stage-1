using System;

namespace Enums

{
    public class Program
    {
        static void Main()
        {
            var t = 85;
            Console.WriteLine(t);
            var s = "";
            int y = 99;
            t = y;



            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Friday);
            //int t = 9;
            Console.WriteLine((WeekDays)t);
            // Console.ReadKey();
            // Student st = new Student();
            // var t = Student.Alice;

            // Console.WriteLine(BasicLessonEnum.Exeptions);
            Console.WriteLine((int)BasicLessonEnum.Exeptions);
           // Console.WriteLine((int)BasicLessonEnum.Classes);
           // var trr = ClassRoomr.Danger;
           // var esim = (int)ClassRoomr.Danger;
           // ClassRoomr classRoomr = new ClassRoomr();





            string classr = ClassRoomr.Danger.ToString();
            int test = (int)ClassRoomr.Danger;
        }
    }
    public enum ClassRoomr
    {
        VipClass = 6,
        Standart = 1,
        PitBoss = 3,
        Danger = 2,
    }
}

