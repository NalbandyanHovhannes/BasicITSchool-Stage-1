using System;

namespace Struct_2
{
    class Program
    {
        static void Main(string[] args)
        {

           // In C#, struct is the value type data type that represents data structures.
           // It can contain a parameterized constructor, static constructor, constants, ]
           // fields, methods, properties, indexers, operators, events, and nested types.












            // Declare c1 of type Car
            // no need to create an 
            // instance using 'new' keyword
            Car c1;

            // c1's data
            c1.Brand = "Bugatti";
            c1.Model = "Bugatti Veyron EB 16.4";
            c1.Color = "Gray";

            // Displaying the values
            Console.WriteLine("Name of brand: " + c1.Brand +
                              "\nModel name: " + c1.Model +
                              "\nColor of car: " + c1.Color);
        }
    }
    public struct Car
    {

        // Declaring different data types
        public string Brand;
        public string Model;
        public string Color;
    }
}
