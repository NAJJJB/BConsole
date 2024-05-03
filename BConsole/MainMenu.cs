using System;
using System.Threading;

namespace ConsoleApplication2
{
    public class MainMenu
    {

        public static void Menu()
        {
            for (;;)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                WriteLogo();
                Say("1", "Checker");
                Say("2", "Info");
                Say("3", "Discord Server");
                Say("4", "Exit");
                string option = Console.ReadLine().ToLower();
                if (option == "1")
                {
                    // Go to checker
                }
                else if (option == "2")
                {
                    //Go to info
                }
                else if (option == "3")
                {
                    DiscordSrv.DiscordServer();
                }
                else if (option == "4")
                {
                    Console.WriteLine("Exiting...");
                    throw new Exception();
                }
                else
                {
                    Console.WriteLine("Error! Please Choose a valid option!");
                    Thread.Sleep(1500);
                }
            }
        }

        public static void Say(string prefix, string message)
        {
            Console.Write("[");
            Console.Write(prefix);
            Console.WriteLine("] " + message);
        }
        public static void WriteLogo()
        {
            string logo = @"  ____   ____                      _      
 | __ ) / ___|___  _ __  ___  ___ | | ___ 
 |  _ \| |   / _ \| '_ \/ __|/ _ \| |/ _ \
 | |_) | |__| (_) | | | \__ \ (_) | |  __/
 |____/ \____\___/|_| |_|___/\___/|_|\___|
                                          ";

            Console.WriteLine(logo);
        }
    }
}