using System;
using System.Threading;

namespace ConsoleApplication2
{
    internal class Exit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ok, see you next time!");
            Thread.Sleep(1000);
            throw new Exception();
        }
    }
}