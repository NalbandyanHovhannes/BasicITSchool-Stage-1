using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Lucel arajin astichani gcayin havasarumy");
            //Console.WriteLine();
            //Console.WriteLine("4x - 8 = 0");
            //Console.WriteLine();
            //Console.Write("x = ");
            //Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Patasxan ` x = ");
            //Console.ReadLine();
            //Console.ReadKey();


            string name = "John";
            string surname = "Smith";
            string FullNmae = name + '\t' + surname;
            Console.WriteLine("Name`" + name);
            Console.WriteLine("Surname`" + surname);
            Console.WriteLine("FullName` " + FullNmae);
            //Console.ReadKey();

            string sttr = name + surname;
            Console.WriteLine(sttr.Length);

            int g = Convert.ToInt32(name.Length) - Convert.ToInt32(surname.Length);
            Console.WriteLine(g);


            int str = Convert.ToInt32(name.Length) - Convert.ToInt32(surname.Length);
            Console.WriteLine(str);


            //string l = name.Substring(2,5);   
            //Console.WriteLine(name);
            char i = 'h';
            char o = 'o';
            bool t = surname.EndsWith(i);
            bool tt = surname.EndsWith(o);
            Console.WriteLine(tt);
            Console.WriteLine(t);

            var e = surname.Clone();
            Console.WriteLine(e);

            bool q = name.EndsWith(i);
            Console.WriteLine(q);

            char er = 'd';
            string r = "Hello World";
            bool re = r.EndsWith(er);
            Console.WriteLine(re);

            char s = 's';
            //string bb = FullNmae.Trim(s);
            //Console.WriteLine(bb);


            string y = "oMOMYo";
            bool yy = y.StartsWith(o);
            Console.WriteLine(yy);

            surname = string.Empty;
            Console.WriteLine("surname = " + surname);

            int a = 8;
            Console.WriteLine(a);


            string b = Convert.ToString(a);
            Console.WriteLine(b);

            bool x = Convert.ToBoolean(a);  // if ( a=0 ) x=false; else x=true 
            Console.WriteLine(x);

            double v = Convert.ToDouble(a);
            Console.WriteLine(a);


            double ss = 5.6666668;
            Console.WriteLine(ss);

            int h = Convert.ToInt32(ss);
            Console.WriteLine(h);

            byte j = Convert.ToByte(ss);
            Console.WriteLine(j);


            int aa = 260;
            //byte bb = Convert.ToByte(aa);   //ex.
            //Console.WriteLine(bb);
            byte ww = 82;
            byte sum = Convert.ToByte( j + ww);
            Console.WriteLine(sum);

            double ee = 500;
            double rr = aa + ee;
            Console.WriteLine("500 + 260 = {0}" , rr);

            decimal ttt = 5.368M;
            int uuu = aa + Convert.ToInt16(ttt);
            Console.WriteLine(uuu);

            float ii = -22;
            int ooo = 3;
            float pp = ii * ooo;
            Console.WriteLine(pp);

            float nn = ooo / ii;
            Console.WriteLine(nn);

            string gg = Convert.ToString(nn);
            Console.WriteLine(gg + '\n' + ii);


            DateTime gggg = new DateTime(2022, 02, 18);
            Console.WriteLine(Convert.ToString(gggg));

            decimal nnnn = ttt * Convert.ToDecimal(ee);
            Console.WriteLine(nnnn);

            decimal ass = 5.23M;
            decimal vc = ass / Convert.ToDecimal(ooo);
            Console.WriteLine(vc);

            ulong iu = 1855555555555ul;
            ulong ui = 3ul;
            ulong io = ui * iu;
            Console.WriteLine(io);

            short mmm = 32454;
            short mnm = 12;
            double mmn = mmm * mnm;
            Console.WriteLine(mmn);


        }
    }
}
