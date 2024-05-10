using System;

namespace ConsoleApplication2
{
    public class Login
    {
        public static void Main(string []args)
        {
            string startCommand;
            Console.Title = "BConsole";
            MainMenu.WriteLogo();
            Console.WriteLine("Welcome to BudgetConsole v1.0");
            Console.WriteLine("This is beta software.");
            Console.Write("Enter start command: ");
            startCommand = Console.ReadLine();
            if (startCommand == "s")
            {
                Console.WriteLine("Starting");
                System.Threading.Thread.Sleep(500);
                Info.licenseCheck();
                MainMenu.Menu();
            }
        }
    }
}