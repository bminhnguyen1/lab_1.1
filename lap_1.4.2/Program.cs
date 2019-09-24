using System;
using System.Collections.Generic;
using System.Text;
namespace lap_1._4._1
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }
    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("weeping...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

        }
    }
}
