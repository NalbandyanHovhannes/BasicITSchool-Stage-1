using System;

namespace Struct_2
{
    class Program
    {
        static void Main()
        {
            // In C#, struct is the value type data type that represents data structures.
            // It can contain a parameterized constructor, static constructor, constants, ]
            // fields, methods, properties, indexers, operators, events, and nested types.
            //93250353
            //string str2=str+str1;


            // Declare c1 of type Car
            // no need to create an 
            // instance using 'new' keyword

            // Car t1=new Car();
            Car c1;

            // c1's data
            c1.Brand = "Bugatti";
            c1.Model = "Bugatti Veyron EB 16.4";
            c1.Color = "Gray";
            //string test=c1.();
            //Console.WriteLine(test);

            // Displaying the values
            Console.WriteLine("Name of brand: " + c1.Brand +
                              "\nModel name: " + c1.Model +
                              "\nColor of car: " + c1.Color);
        }
    }
    public struct Car
    {        // Declaring different data types
        public string Brand;
        public string Model;
        public string Color;
        public string Adding()
        { 
            return Brand+Model;
        }
     
    }
    public readonly struct Coords
    {
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; init; }
        public double Y { get; init; }

        public override string ToString() => $"({X}, {Y})";
    }
}
