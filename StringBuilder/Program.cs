using System;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            string text = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"

            //Concatenation
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            string firstNames = "John ";
            string lastNames = "Doe";
            string names = string.Concat(firstName, lastName);
            Console.WriteLine(name);


            //String Interpolation
            //string firstName = "John";
            //string lastName = "Doe";
            //string name = $"My full name is: {firstName} {lastName}";
            //Console.WriteLine(name);


            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"



            string myStrings = "Hello";
            Console.WriteLine(myStrings.IndexOf("e"));  // Outputs "1"

            // Full name
            string nname = "John Doe";

            // Location of the letter D
            int charPos = nname.IndexOf("D");

            // Get last name
            string llastName = nname.Substring(charPos);

            // Print the result
            Console.WriteLine(llastName);

            // string txt = "We are the so-called "Vikings" from the north.";
            string txtr = "We are the so-called \"Vikings\" from the north.";

            string txxt = "It\'s alright.";

            string txct = "The character \\ is called backslash.";

            int x = 10;
            int y = 20;
            int z = x + y;

            //string x= "10";
            //string y= "20";
            //string z = x + y;  // z will be 1020 (a string)

            //StringBuilder sb = new StringBuilder(50); //string will be appended later
            //                                          //or
            //StringBuilder sbs = new StringBuilder("Hello World!", 50);





        }
    }
}
