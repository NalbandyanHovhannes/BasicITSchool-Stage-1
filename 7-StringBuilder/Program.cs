using System;
using System.Text;

namespace _7_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {




            //1.StringBulder
            // StringBuilder sb = new StringBuilder();

            //or

            // StringBuilder sb = new StringBuilder("its a stringbuilder");
            // StringBuilder stringBuilder = new StringBuilder();

            var sb = new StringBuilder("Название: ");
            Console.WriteLine(sb);   // Название: 
            Console.WriteLine($"Длина: {sb.Length}"); // 10
            Console.WriteLine($"Емкость: {sb.Capacity}"); // 16

            sb.Append(" Руководство");
            Console.WriteLine(sb);   // Название: Руководство
            Console.WriteLine($"Длина: {sb.Length}"); // 22
            Console.WriteLine($"Емкость: {sb.Capacity}"); // 32

            sb.Append(" по C#");
            Console.WriteLine(sb);   // Название: Руководство по C#
            Console.WriteLine($"Длина: {sb.Length}"); // 28
            Console.WriteLine($"Емкость: {sb.Capacity}"); // 32


            StringBuilder newsb = new StringBuilder();
            StringBuilder sbb = new StringBuilder("Hello World!");

            sbb = new StringBuilder("Hello World!");

            for (int intt = 0; intt < sbb.Length; intt++)

                Console.Write(sbb[intt]);
            string a = sbb.ToString();

        }
    }
}
