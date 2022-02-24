using System;

namespace ForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please entre count of array...");
            int n = int.Parse(Console.ReadLine());             
            
            int[] array = new int[n];
            int min = 0;
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
          
                min = (array[i] < min) ? array[i] : min;
            }
            Console.WriteLine(min);
        }
    }
}
