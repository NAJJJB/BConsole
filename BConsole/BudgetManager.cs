using System;
using System.Threading;

namespace ConsoleApplication2
{
    public class BudgetManager
    {
        public static void BudgetMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            MainMenu.WriteLogo();
            Console.WriteLine("Budget Manager");
            Console.WriteLine("[1] Add Budget");
            Console.WriteLine("[2] View Budget");
            Console.WriteLine("[3] Edit Budget");
            Console.WriteLine("[4] Delete Budget");
            Console.WriteLine("[5] Back to Main Menu");
            string option = Console.ReadKey().KeyChar.ToString();
            if (option == "1")
            {
            }
            else if (option == "2")
            {
            }
            else if (option == "3")
            {
                BudgetEdit.EditBudget();
            }
            else if (option == "4")
            {
                
            }
            else if (option == "5")
            {
                MainMenu.Menu();
            }
            else
            {
                Console.WriteLine("Error! Please Choose a valid option!");
                Thread.Sleep(1500);
            }
        }
    }
}