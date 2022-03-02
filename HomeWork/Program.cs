

using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {




        }
        public int Foo(int n,int j,int count)
        {
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                if (n % i == 0)
                {
                    c++;
                }
            }
                if (c==2)
                {
                count++;
                Foo(n - 1, j, count);
                }

            if (j<n)
            {
                Foo(n - 1, j, count);
            }
            return 1;
        }

    }
}
