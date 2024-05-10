using System;
using System.IO;
using System.Net;

namespace ConsoleApplication2
{
    public class Info
    {
        public static void licenseCheck()
        {
            string licenseFile = "C:\\license.txt";
            string licenseHolder = File.ReadAllText(licenseFile);
            
            if (!File.Exists(licenseFile))
            {
                Console.WriteLine("License file not found. Please contact the developer.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            if (licenseHolder == "" || licenseHolder == null)
            {
                Console.WriteLine("License file is empty. Please contact the developer.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        public static void InfoMenu()
        {
            string licenseFile = "C:\\Users\\neoma\\RiderProjects\\BConsole\\BConsole\\license.txt";
            string licenseHolder = File.ReadAllText(licenseFile);
            
            if (!File.Exists(licenseFile))
            {
                Console.WriteLine("License file not found. Please contact the developer.");
                Console.ReadKey();
                return;
            }

            if (licenseHolder == "" || licenseHolder == null)
            {
                Console.WriteLine("License file is empty. Please contact the developer.");
                Console.ReadKey();
                return;
            }
            
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            MainMenu.WriteLogo();
            Console.WriteLine($"BudgetConsole v1.0 built with love by NAJJJB");
            Console.WriteLine("Licensed to: " + licenseHolder);
            Console.ReadKey();
        }
    }
}