using System;
using System.Threading;

namespace Les2VariablesEnDatatypes
{
    class Program
    {
        static void Main(string[] arg)
        {
            int getal1 = 1;
            float getal2 = getal1;
            int getal3 = 75;
            char getal4 = (char)getal3;
            Console.WriteLine(getal1 + " " + getal2 + " " + getal3 + " " + getal4);
        }
    }
}