using System;

namespace Les3SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = 0;
            try
            {
                number = Int32.Parse(input);
                switch (number)
                {
                    case 23:
                        Console.WriteLine("23, dat is hoeveel letters in de naam Micropachycephalosaurus zit!");
                        Console.ReadLine();
                        return;
                    case 2:
                        Console.WriteLine("Ik haat vrouwen");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Je hebt het getal " + number + " ingevoerd jij onnozele ziel UwU");
                        Console.ReadLine();
                        return;
                }
            }
            catch
            {
                Console.WriteLine("No Number + No Bitches + Clown + Ratio + L");
            }
            Console.Read();
        }
    }
}