using System;
using System.IO;

namespace ConsoleApplication2
{
    public class BudgetEdit
    {
        public static void EditBudget()
        {
            Console.Clear();
            MainMenu.WriteLogo();
            Console.WriteLine("Edit Budget");
            Console.Write("Enter Budget Name: ");
            string budgetName = Console.ReadLine();
            Console.Write("Enter Budget Amount: ");
            string budgetAmount = Console.ReadLine();
            Console.Write("Enter Budget Description: ");
            string budgetDesc = Console.ReadLine();
            Console.WriteLine("Budget Edited Successfully!");
            Console.WriteLine("Press any key to return to Budget Manager...");
            Console.ReadKey();
            BudgetManager.BudgetMenu();
        }
    }
}