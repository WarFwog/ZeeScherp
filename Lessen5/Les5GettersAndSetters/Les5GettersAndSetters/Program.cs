using System;

namespace Les5GettersAndSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Ball groenebal = new Ball("de groene bal");
            Ball Mo = new Ball("de kleine bal");
            dog.FetchBall(Mo);
            Console.WriteLine(dog.GiveBall().naam);
            dog.FetchBall(groenebal);
            Console.WriteLine(dog.GiveBall().naam);

            Ball huidigeBall = dog.GiveBall();
        }
    }
    class Dog
    {
        private Ball BallInMond;
        public void FetchBall(Ball ball)
        {
            this.BallInMond = ball;
        }
        public Ball GiveBall()
        {
            return BallInMond;
        }
    }
    class Ball
    {
        public string naam;
        public Ball(string naam)
        {
            this.naam = naam;
        }
    }
}