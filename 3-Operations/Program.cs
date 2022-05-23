using System;

namespace _3_Operations
{
    public class Program
    {
        static void Main(string[] args)
        {

            static int Method1<T>(T a, T b)
            {
                return 7;
            }

            var u = Method1<int>(9, 8);

            Console.WriteLine(u);

        }
    }
}
