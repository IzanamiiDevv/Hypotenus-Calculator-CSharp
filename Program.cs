using System;
using Hypotenus;
using StyleCode;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Write the value of A");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Write the value of B");
        double b = Convert.ToDouble(Console.ReadLine());

        Style.Green(Hypo.Calc(a,b),"The Hypotenus is: ");
    }
}