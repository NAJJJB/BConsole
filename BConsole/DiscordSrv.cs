﻿using System;

namespace ConsoleApplication2
{
    public class DiscordSrv
    {
        public static void DiscordServer()
        {
            Console.Clear();
            Console.WriteLine($"Join our discord server at: {Constants.Urls.DiscordServer}");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }
    }
}