using System;

namespace Enums

{
    public class Program
    {
        static void Main()
        {
             
            WeekDays days = new WeekDays();
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Friday);
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

