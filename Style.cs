using System;

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