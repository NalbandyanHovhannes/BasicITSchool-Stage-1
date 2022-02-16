using System;

namespace _3_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. ++,-- inc,dec
            //2. Local Global
            //3. Math
            //4. Comparison
            //5. Checket
            //6. Concotenation
            //7. String Format
            //8. Sizeof
            //9. Var

            //part 1
            int number = Convert.ToInt32(Console.ReadLine());//2341
            Console.WriteLine("---------");

            int lastNumber4 = number % 10;      //1
            int newNumber3 = number / 10;       //234
            int lastNumber3 = newNumber3 % 10;  //4
            int newNumber2 = newNumber3 / 10;   //23
            int lastNumber2 = newNumber2 % 10;  //3
            int numNumber1 = newNumber2 / 10;   //2
            int lastNumber1 = numNumber1 % 10;  //2

            int result = lastNumber1 + lastNumber2 + lastNumber3 + lastNumber4;
            string text = "Result=" + result;
            Console.WriteLine(text);

            //---------------------------------------
            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)
            Math.Max(5, 10);
            Math.Min(5, 10);
            var y = Math.Sqrt(64);
            Math.Abs(-4.7);
            Math.Round(9.99);
            if (sum3 > 500)
            {
                Console.WriteLine("sum3 is biggest and equal {0}", sum3);
            }
            else 
            { Console.WriteLine("sum3 is small and equal  {1}", 500); }

            //CTRL KD

            //(sum3>500) ? (Console.WriteLine("sum3 is biggest and equal {0}", sum3)) : (Console.WriteLine("sum3 is small and equal  {1}", 500)); 

            //7. String Format
            Console.WriteLine("Barev es {0} em {1} tarekan", "Van", 30);
            Console.ReadKey();
            //6. Concotenation
            string firstName = "Robert";
            string lastName = "Kocharyan";
            string whiteSpace = " ";
            string n = "\n";
            string name = firstName + n + lastName + "\n" + "azatutyun naxagahiun"; //Concotenation
            Console.WriteLine(name);

            Console.ReadKey();
            //5. Checket
            byte by = 255;

            checked
            {
                unchecked
                {
                    by += 1;
                }
            }
            Console.WriteLine(by);
            Console.ReadKey();

            //4. Comparison
            int n1 = 26;
            int n2 = 26;
            bool b = n1 != n2;
            Console.WriteLine(b);
            Console.ReadKey();

            //3. Math
            double pi = Math.PI;
            double pow = Math.Floor(1.53468464);
            Console.WriteLine(pow);
            Console.ReadKey();
            //2.  Local Global
            int k = 4;
            {
                //int k = 4;
                int x = 5;
            }

            {
                int x = 6;
            }

            //1.++,--
            int numbers = 5;

            Console.WriteLine(--numbers);//number=number-1;  cw(number)
            Console.WriteLine(numbers--);//cw(number);       number=number-1;
            Console.WriteLine(numbers);//3
            Console.ReadKey();
            //number = number + 1;




        }
    }
}
