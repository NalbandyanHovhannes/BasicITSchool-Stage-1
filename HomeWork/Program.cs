

using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Reco(7, 0);
            int? t = 8;
            // int k = null;

            const int Months = 12;
            const int Weeks = 52, Days = 365;


            int u = 9;
            // string k = char.Parse(u);

            string? str = "8";
            //string str2 = str;


        }
         readonly string tes = "";
        public static int Reco(int t,int sum)
        {
            Console.WriteLine(sum + Reco(t, sum));

            return sum + Reco(t, sum);
        
        }
    }
}
