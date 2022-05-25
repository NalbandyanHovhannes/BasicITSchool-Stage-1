

using System;

namespace HomeWork
{
    class Program
    {
        //random
        //get set
        //ref out
        //thread sleep
        //datetime

        static void Main(string[] args)
        {
            
     
        }
        public static string GetNextName(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            int t=9;
            int u;
            GetNextNames(ref t, out u);
            return returnText;

        }
        public static string GetNextNames(ref int u ,out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }

    }

}
