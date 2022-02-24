using System;

namespace ForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please entre count of array...");
            int n = int.Parse(Console.ReadLine()); int i;
            int[] array = new int[n]; int min = array[0];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
