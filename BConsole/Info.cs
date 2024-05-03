using System;

namespace ConsoleApplication2
{
    public class Info
    {
        public static void InfoMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            MainMenu.WriteLogo();
            Console.WriteLine($"BudgetConsole v1.0 built with \u2764 by NAJJJB");
            Console.ReadKey();
        }
    }
}