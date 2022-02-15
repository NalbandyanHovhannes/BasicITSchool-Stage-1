Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Hello, World!");
var a = Console.ReadLine();
var b = Console.ReadLine();
int c = 0;
int d = 0;
int.TryParse(a, out c);
int.TryParse(b, out d);
Console.WriteLine(c + d);

int number;
Console.Write("Մուտքագրեք թիվ:");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Արդյունք :{0}", number);


string name, sname;
Console.Write("Անուն:");
name = Console.ReadLine();
Console.Write("Ազգանուն:");
sname = Console.ReadLine();
Console.WriteLine("Ողջույն :{0}", name + " " + sname);

double dollar_amount, dram;
int cur = 495;

Console.Write("Enter dollar amount :");
dollar_amount = Convert.ToDouble(Console.ReadLine());

dram = (int)(dollar_amount * cur);

Console.WriteLine("{0} $  = {1} AMD", dollar_amount, dram);


Console.ReadKey();

////////////////////////