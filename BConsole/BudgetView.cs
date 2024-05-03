using System;
using System.Threading;

namespace ConsoleApplication2
{
    public class BudgetView
    {
        public static void ViewBudget()
        {
            Console.Clear();
            MainMenu.WriteLogo();
            Console.WriteLine("View Budgets");
            Console.WriteLine("Select Budget to View:");
            Console.WriteLine("THIS IS A W.I.P, NO BUDGETS TO DISPLAY YET!");
            Console.WriteLine("Returning to Budget Manager...");
            Thread.Sleep(2500);
            BudgetManager.BudgetMenu();
        }
    }
}