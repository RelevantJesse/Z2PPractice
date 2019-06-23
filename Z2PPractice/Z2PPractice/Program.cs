using System;

namespace Z2PPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Bark();

            Fish myFish = new Fish();
            myFish.Name = "Bob";
        }
    }

    abstract class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void Breathe()
        {
            Console.WriteLine("I'm breathing");
        }

        public void Eat()
        {
            Console.WriteLine("I'm eating");
        }
    }

    class Dog : Animal
    {
        public int NumberOfLegs { get; set; }

        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }
    }

    class Fish : Animal { 

    }
}
