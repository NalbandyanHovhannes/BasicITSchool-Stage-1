using System;

namespace _3_Operations
{
   public class Program
    {
        static void Main(string[] args)
        {

            //-----------------------------------------------------------------------------------------
            //1. ++,-- inc,dec
            int x = 0;
            System.Console.WriteLine( x++ );
            System.Console.WriteLine( x-- );
            System.Console.WriteLine( ++x);
            System.Console.WriteLine(--x);
            x++;
            x--;
            --x;
            ++x;

            int numbers = 5;
            Console.WriteLine(--numbers);//number=number-1;  cw(number)
            Console.WriteLine(numbers--);//cw(number);       number=number-1;
            Console.WriteLine(numbers);//3
            Console.ReadKey();
            numbers = numbers + 1;


            int y = 5;

            int t = y % 3;//modulus //1
            y %= 2;//x=x%2

            //+=, -=, *=, /=
            y += 3;//x=x+3
            y *= 3;//x=x*3
            y /= 3;//x=x/3
            y -= 3;//x=x-3


            //-----------------------------------------------------------------------------------------
            ////2. Local Global
            //int k = 4;
            //{
            //    //int k = 4;
            //    int xx = 5;
            //}

            //{
            //    int xxx = 6;
            //}

            //-----------------------------------------------------------------------------------------
            //3. Math

            Math.Max(5, 10);
            Math.Min(5, 10);
            var yy = Math.Sqrt(64);
            Math.Abs(-4.7);
            Math.Round(9.99);

            double pi = Math.PI;
            double pow = Math.Floor(1.53468464);
            Console.WriteLine(pow);
            Console.ReadKey();

            //-----------------------------------------------------------------------------------------
            //4. Comparison
            int n1 = 26;
            int n2 = 26;
            bool b = n1 != n2;
            Console.WriteLine(b);
            Console.ReadKey();

            //-----------------------------------------------------------------------------------------
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



            //-----------------------------------------------------------------------------------------
            //6. Concotenation
            string firstName = "Robert";
            string lastName = "Kocharyan";
            string whiteSpace = " ";
            string n = "\n";
            string name = firstName + n + lastName + "\n" + "azatutyun naxagahiun"; //Concotenation
            Console.WriteLine(name);
            Console.ReadKey();



            //-----------------------------------------------------------------------------------------
            //7. String Format
            Console.WriteLine("Barev es {0} em {1} tarekan", "Hovo", 30);
            Console.ReadKey();


            //8. Sizeof



            //9. Var
           // BIt
            Console.WriteLine(3 & 4);
            Console.WriteLine(3 | 4);
            Console.WriteLine(3 ^ 4);
            Console.WriteLine(~4);
            Console.WriteLine(4 >> 2);
            Console.WriteLine(4 << 2);


            //string s1 = "ssss";
            //string s2 = "iiii";
            //string strr = s1.Remove(); - s2;
            //int lastNumber4 = number % 10;      //1
            //int newNumber3 = number / 10;       //234
            //int lastNumber3 = newNumber3 % 10;  //4
            //int newNumber2 = newNumber3 / 10;   //23
            //int lastNumber2 = newNumber2 % 10;  //3
            //int numNumber1 = newNumber2 / 10;   //2
            //int lastNumber1 = numNumber1 % 10;  //2

            // int result = lastNumber1 + lastNumber2 + lastNumber3 + lastNumber4;
            // string text = "Result=" + result;
            //Console.WriteLine(text);

            //---------------------------------------


            //CTRL KD



            //-------------------------------3--------------------------------------
            //string firstName = "John";
            //const string lastName = "Smith";
            //const byte age = 52;
            //const string gender = "male";

            ////bad practice 
            //string badText = firstName + '\n' + lastName + "\t" + age + " " + gender;

            ////good practice
            //string goodText = $"firstName : {firstName} \nlastName : {lastName} \nage : {age} \ngender : {gender}";
            //firstName = "Alex";

            //Console.WriteLine(goodText);
            //Console.WriteLine(firstName);

            //var xxxx = 5;
            //xxxx = "hello"; //error

            ////dynamic a = 45;
            ////a = "asc";

          
            //------------------------------4-------------------------------

            //const string firstName = "Robert";
            ////firstName += "h";
            //string lastName = "Kocharyan";
            //string middleName = "Vova";
            //string fullNameConcat = firstName + middleName + lastName;//concatenation //bad practice
            //string fullNameFormat = string.Format("{0} {1} {2}", firstName, middleName, lastName);
            //string fullName = $"{firstName} {middleName} {lastName}";//interpolation 

           

        }
    }
}
