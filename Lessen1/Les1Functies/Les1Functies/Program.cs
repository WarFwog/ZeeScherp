using System;

namespace Les1Functies
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse("Micropachycephalosaurus");
        }
        static void Reverse(string input)
        {
            string leeg = "";

            foreach (char c in input)
            {
                leeg = leeg.Insert(0, Convert.ToString(c));
            }
            Console.WriteLine(leeg);
        }
    }
}