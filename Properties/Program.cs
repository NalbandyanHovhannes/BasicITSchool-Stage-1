using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RequestModel requestModel = new RequestModel();
            requestModel.Authentication = 90;
            Console.WriteLine( requestModel.X);
        }
    }
}
