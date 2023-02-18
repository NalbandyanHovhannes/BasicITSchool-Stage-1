using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{

    public static class StaticClass
    {
        private static int name; // field

        public static string Name   // property
        {
            get;    // get method
            set;   // set method
        }
        public static int MyProperty {
            get
            {
                return name;
            } 
            set 
            {
                for (int i = 0; i < 8; i++)
                {

                }
               name = value * 2;
            } 
        }
        public static int a;
        public static int b;
        public static int Method()
        { return 1; }
        static readonly int y = 8;

        static StaticClass()
        {

        }

    }
    public class NonStat
    {
        public static int Prop1 { get; set; }
        int a;
        static int b;
        public static int Method()
        { return 1; }
        static readonly int y = 8;
        public NonStat()
        {

        }
        public NonStat(int y)
        {
            this.a = y;
        }
    }
}
