using System;

namespace _2_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;                //Default is false   8-bit logical true/false value

            byte b = 0;                   //8 bit 0-255
            sbyte i = 7;                  //8-bit unsigned integer

            char c = 'v';                 //16-bit single Unicode character

            short sh = 2;                 //16-bit signed integer
            ushort ssh = 2;               //16-bit unsigned integer

            int g = 5;                    //32-bit signed integer
            uint k = 6;                   //32-bit unsigned integer

            float f = 6.7f;               //32-bit Single-precision floating point type  suffix f

            long h = 785;                 //64-bit unsigned integer  suffix ul
            ulong l = 789625212;          //64-bit unsigned integer  suffix ul

            decimal d = 6.3m;             //128-bit decimal type for financial and monetary calculations suffix m
          
            

            Console.WriteLine("Reference Types");
            string str = "String is reference type";

            Console.WriteLine("Dynamic Type");
            dynamic Dinamic = 8;
            Console.ReadKey();

            char t = 'h';
            int kk = t;
            string values = t.ToString();

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

            string s;
            object ii = null;
            s = ii.ToString();
            //returns a null reference exception for s.

            string sss;
            object o = null;
            sss = Convert.ToString(o);
            //returns an empty string for s and does not throw an exception.

            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Your age is: " + age);


            int num;
            object oo= null;
            num = Convert.ToInt32(oo);


            int numm;
            object ooo = null;
            //num = int.Parse(ooo);




            //Anonymus Types
            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine(student.Id); //output: 1
           // student.Id = 9;
            Console.WriteLine(student.FirstName); //output: James
            Console.WriteLine(student.LastName); //output: Bond

            //student.Id = 2;//Error: cannot chage value read only
            //student.FirstName = "Steve";//Error: cannot chage value


            //Dynamic Type
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            //Nullable Type
            int? kyy = null;
            double? kt = null;


        }
    }
}
