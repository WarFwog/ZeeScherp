using System;

namespace Les6Overerving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal SevenFootTallhorse = new Horse();
            Animal Gingerhorse = new Horse();
            Console.WriteLine(SevenFootTallhorse.MeasureFatness());
            SevenFootTallhorse.Feed(5);
        }
    }
    class Animal
    {
        protected int hunger
        {
            get
            {
                return _hunger;
            }
            set
            {
                if (value > hungermax)
                    value = hungermax;
                _hunger = value;
            }
        }
        private int _hunger;
        protected int hungermax
        {
            get; set;
        }
        public void Feed(int v)
        {
            hunger -= 1;
        }
        public void Starve(int ammount)
        {
            hunger -= ammount;
        }
        public int MeasureFatness()
        {
            return hunger;
        }
    }
    class Horse : Animal
    {
        public Horse()
        {
            hungermax = 100;
            hunger = 100;
        }
        public void Feed(int ammount)
        {
            hunger += ammount;
        }
    }
}
