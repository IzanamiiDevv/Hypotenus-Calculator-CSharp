using System;
using Hypotenus;
using StyleCode;


class Program
{
    public static void ReadLinefromUser()
    {
        Console.WriteLine("Write the length of leg A");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Write the length of leg B");
        double b = Convert.ToDouble(Console.ReadLine());

        Style.Green(Hypo.Calc(a,b),"The Hypotenuse is: ");
    }
    
static void Main(string[] args)
    {
        ReadLinefromUser();
    }

    
}

namespace StyleCode
{
    class Style
    {
        public static void Green<T>(T args,string txt)
        {
            Console.Write(txt);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(args);
            Console.ResetColor();
        }
    }
}

namespace Hypotenus
{
    class Hypo
    {
        public static double Calc(double x,double y)
        {
            return Math.Sqrt((x*x)+(y*y));
        }

    }
}
