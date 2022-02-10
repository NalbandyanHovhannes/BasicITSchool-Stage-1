using System;

namespace _2_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            byte b = 0;
            char c = 'v';
            decimal d = 6.3m;
            double e = 6.8;
            float f = 6.7f;
            int g = 5;
            long h = 785;
            sbyte i = 7;
            short j = 5;
            uint k = 6;
            ulong l = 789625212;
            ushort o = 5523;

            Console.WriteLine("Reference Types");
            string str = "String is reference type";

            Console.WriteLine("Dynamic Type");
            dynamic Dinamic = 8;
            Console.ReadKey();

            const int _const = 8;

            double myDouble = 9.78;
            int myInt = (int)myDouble;

            int myint = 9;
            double mydouble = myInt;

            
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Your age is: " + age);


            //Anonymus Types
            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine(student.Id); //output: 1
            Console.WriteLine(student.FirstName); //output: James
            Console.WriteLine(student.LastName); //output: Bond

            //student.Id = 2;//Error: cannot chage value
            //student.FirstName = "Steve";//Error: cannot chage value


            //Dynamic Type
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            //Nullable Type
            int? kyy= null;
            double? kt = null;


        }
    }
}
