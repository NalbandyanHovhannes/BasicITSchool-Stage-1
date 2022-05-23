

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
            return returnText;
        }
        public static string GetNextNames(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }

    }

}
