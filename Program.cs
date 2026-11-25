using System;
using Hypotenus;
using StyleCode;

class Program
{
    public static void ReadLinefromUser()
    {
        Console.WriteLine("Write the leg of A");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Write the leg of B");
        double b = Convert.ToDouble(Console.ReadLine());

        Style.Green(Hypo.Calc(a,b),"The Hypotenuse is: ");
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
