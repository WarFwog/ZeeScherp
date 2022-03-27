using System;
using System.Threading;

namespace Les1FunctiesReturn
{
    class Program
    {
        static float nummer()
        {
            Random rand = new Random();
            float rnd = rand.Next(0, 20);
            return rnd;
        }
        static void Main(string[] args)
        {
            nummer();
            Console.WriteLine(nummer());
        }
    }
}