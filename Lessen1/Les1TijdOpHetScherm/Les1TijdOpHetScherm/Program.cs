using System;
using System.Threading;

namespace Les1TijdOpHetScherm
{
    class Program
    {
        static void Main(string[] args)
        {
            int ColorCounter = 0;
            int Colorindex = 0;
            ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.DarkMagenta, ConsoleColor.DarkGreen };
            while (true)
            {
                DateTime Now = DateTime.Now;
                Console.Write("\r" + Now.ToString("HH:mm:ss"));
                Thread.Sleep(1000);
                ColorCounter++;
                if (ColorCounter >= 3)
                {
                    ColorCounter = 0;
                    Console.ForegroundColor = colors[Colorindex];
                    Colorindex++;
                    if (Colorindex >= colors.Length) Colorindex = 0;
                }
            }
            
        }
    }
}
