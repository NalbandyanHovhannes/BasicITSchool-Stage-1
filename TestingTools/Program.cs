

public class Program
{
    static void Main()
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        // t = Calc(10);
        var y = 5;
        Calc2(y);
        Console.WriteLine(y);
        Console.ReadKey();


        Calc(1);
        Calc(1, 2);
        Calc("");
        var t = "";
    }

    public static string Calc(string a)
    {
        var sum = a;
        return sum;
    }
    public static int Calc(int a)
    {
        var sum = a * a;
        return sum;
    }
    public static int Calc(int a,int b)
    {
        var sum = a * a;
        return sum;
    }

    public static void Calc2( int t)
    {
        ++t;
    }

}