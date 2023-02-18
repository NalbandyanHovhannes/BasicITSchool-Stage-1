using System;
using System.Data;

namespace _2_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {


            //double doub=25.555;
            //Console.WriteLine(doub);
            //float flo= 26.555455555555555555555555555f;
            //Console.WriteLine(flo);
            //decimal dec= 27.5555555555555555555555555554m;
            //Console.WriteLine(dec);
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(decimal.MaxValue);


            //decimal tt = (decimal)flo;
            //decimal sum = Convert.ToDecimal((double )flo + doub);


            //char v1 = 'c';
            //char v2 = 'v';
            //int  uu = v1 + v2;
            //Console.WriteLine((char)uu);
            //Console.WriteLine("sjjjjjjjjjjjjjjjjjjjj");


            //double dbtest = 28.6d;
            //string sttest = dbtest.ToString();
            //Console.WriteLine(sttest);








            //int b = 0b101;
            //Console.WriteLine();
            ////  char v1 = 'c';
            ////  char v2 = 'v';
            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(v1);
            //Console.WriteLine(v2);
            //            char tttt = 't';

            //   int sumChar = vvvv + tttt+tttt;

            //int t, y, o;
            //int a=8 ;
            //int b = 3;
            //int d = 0;
            //int c = a + b;
            //int zero;
            //zero= b / d;

            // DateTime t = DateTime.Now;
            //// DateTime y =dateTime.Date= "29.06.2022 22:02:35".date;
            // Console.WriteLine(t); ;
            //int age = 18;
            //string firstName = "John ";
            //string lastName = "Doe";
            //string fullName = firstName + lastName + age;
            //Console.WriteLine(fullName);

            //   bool a = false;
            //   char c = 'v';                 //16-bit single --Unicode character 2bit
            //   char u = 'i';                 //
            //   char add = (char)(c + u);

            //   //Default is false   8-bit logical true/false value
            //   a = true;
            //   bool uu;


            //   byte b = 255;//0-255   0.1  2
            //   byte bb = 125;
            //   int tt = b - bb; 
            //   //8 bit 0-255
            //   sbyte i = 7;                  //8-bit unsigned integer

            //            int aa = 520;
            //            int bbb = 99;
            //            int result = bbb*aa;
            //            int io;

            //            byte x = (byte)(aa);
            //            double ttt = 2d / 3;
            //            Console.WriteLine(ttt);

            ////            float flt = 1F / 3;
            ////            double dbl = 1D / 3;
            ////            decimal dcm = 1M / 3;
            ////            Console.WriteLine("float: {0} double: {1} decimal: {2}", flt, dbl, dcm);
            ////        Result:
            ////            float: 0.3333333
            //double: 0.333333333333333
            //decimal: 0.3333333333333333333333333333




            //            //char c = 'v';                 //16-bit single --Unicode character 2bit
            //            //char u = 'i';                 //
            //            //char add = (char)(c + u);     //

            //            int value = c + u;            //

            //            short sh = 2;                 //16-bit signed integer
            //            ushort ssh = 2;               //16-bit unsigned integer
            //            //short to short =int

            //            int g = 5;                    //32-bit signed integer
            //            uint k = 6;                   //32-bit unsigned integer

            //            float f = 6.78f;              //32-bit Single-precision floating point type  suffix f
            //            //A.3 by default double
            //            double db = 8.9d;             //64-bit 

            //            long h = 785;                 //64-bit unsigned integer  suffix l
            //            ulong l = 789625212;          //64-bit unsigned integer  suffix ul

            //            decimal d = 6.3m;             //128-bit decimal type for financial and monetary calculations suffix m money

            //            //imutable  string dont changed
            //            //mutable changed value types

            // Console.WriteLine("Reference Types");
            // string str = "String is reference type";
            // string str2 = "str2";
            // string str3 = str + str2;

            // bool str4 = str.Contains('F');
            //     int str5 = str.GetHashCode();



            // Console.WriteLine("Dynamic Type");
            // dynamic Dinamic = 8;
            // Console.ReadKey();

            // char t = 'h';
            // int kk = t;
            // string values = t.ToString();

            // const int _const = 8;
            // readon

            // double myDouble = 9.78;
            // int myInt = (int)myDouble;

            // int myint = 9;
            // double mydouble = myInt;


            // bool myBool = true;

            // Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            // Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            // Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            // Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            // string s;
            // object ii = null;
            // s = ii.ToString();
            // //returns a null reference exception for s.

            // string sss;
            // object o = null;
            // sss = Convert.ToString(o);
            // //returns an empty string for s and does not throw an exception.

            // Console.WriteLine("Enter your age:");
            // string age = Console.ReadLine();
            // Console.WriteLine("Your age is: " + age);


            // int num;
            // object oo= null;
            // num = Convert.ToInt32(oo);


            //int numm;
            //object ooo = null;
            //num = int.Parse(ooo);
            //int u = 8988;

            //dynamic dyn = u;
            //string s = "888";
            ////dyn = s;

            //string str =dyn;

            //var a = 8;
            //a = "";
            //string str =dyn;

            //Anonymus Types 

            var student = new[]  { new { Id = 1, FirstName = "James", LastName = "Bond" },
                                new { Id = 1, FirstName = "James", LastName = "Bond" } };
        //var student = new {{ Id = 1, FirstName = "James", LastName = "Bond" },{ Id = 1, FirstName = "James", LastName = "Bond" } };
        //    Console.WriteLine(student.Id); //output: 1
        //    Console.WriteLine(student.FirstName); //output: 1
        //    Console.WriteLine(student.LastName); //output: 1
        //    //student.Id = 9;
        //    Console.WriteLine(student.FirstName); //output: James
        //    Console.WriteLine(student.LastName); //output: Bond

            // //student.Id = 2;//Error: cannot chage value read only
            // //student.FirstName = "Steve";//Error: cannot chage value


            //Dynamic Type
            //dynamic MyDynamicVar = 100;
            //Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());
            //string str = "85241Asss";
            ////string strValues = MyDynamicVar / str;

            ////Nullable Type 
            //int? kyy = null;
            //double? kt = null;

            ////Implicit Casting automate
            //int myIntt = 9;
            //double myDoublee = myInt;
            //// Explicit Casting
            //double myDoubleee = 9.78;
            //int myIntyy = (int)myDouble;
            //int myIntyyy = 10;




        }
    }
}
