using System;
using Hypotenus;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Write the value of A");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Write the value of B");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The Hypotenus is: {Hypo.Calc(a,b)}");
    }
}