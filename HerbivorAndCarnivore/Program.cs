using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorAndCarnivore
{
    interface Heribore
    {
         void EatPlants();
    }
    interface Carnivore
    {
        void EatMeat(); 
    }
    public class Goat: Heribore
    {
        public void EatPlants()
        {
            Console.WriteLine("Goat is a Herbivore animal...");
        }
    }
    public class Human : Heribore
    {
        public void EatPlants()
        {
            Console.WriteLine("Human is a Harbivore and carnivore ....");
        }
    }
    public class Cat : Carnivore
    {
        public void EatMeat()
        {
            Console.WriteLine("Cat is carnivore animal...");
        }
    }
    public class Dog : Carnivore
    {
        public void EatMeat()
        {
            Console.WriteLine("Dog is Carnivore animal...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.EatMeat();
            Cat c1 = new Cat();
            c1.EatMeat();
            Human h1 = new Human();
            h1.EatPlants();
            Goat g1 = new Goat();
            g1.EatPlants();
            Console.ReadLine();
        }
    }
}
