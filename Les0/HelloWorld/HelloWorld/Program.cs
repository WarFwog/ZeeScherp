using System;
using System.Threading;

namespace boop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string text = "Hello World!";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(1000);
            }
        }
    }
}
