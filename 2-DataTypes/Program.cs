﻿using System;

namespace _2_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
//            char vvvv = 'v';
//            char tttt = 't';

//            int sumChar = vvvv + tttt+tttt;



//            bool a = false;
//            char c = 'v';                 //16-bit single --Unicode character 2bit
//            char u = 'i';                 //
//            char add = (char)(c + u);

//            //Default is false   8-bit logical true/false value
//            a = true;
//            bool uu;

            
//            byte b = 255;//0-255   0.1  2
//            byte bb = 125;
//            int tt = b - bb; 
//            //8 bit 0-255
//            sbyte i = 7;                  //8-bit unsigned integer

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
////double: 0.333333333333333
////decimal: 0.3333333333333333333333333333




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


           // int numm;
           // object ooo = null;
           // //num = int.Parse(ooo);




           // //Anonymus Types
           // var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
           // Console.WriteLine(student.Id); //output: 1
           //// student.Id = 9;
           // Console.WriteLine(student.FirstName); //output: James
           // Console.WriteLine(student.LastName); //output: Bond

           // //student.Id = 2;//Error: cannot chage value read only
           // //student.FirstName = "Steve";//Error: cannot chage value


            //Dynamic Type
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());
            string str = "85241Asss";
            string strValues = MyDynamicVar / str;

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
