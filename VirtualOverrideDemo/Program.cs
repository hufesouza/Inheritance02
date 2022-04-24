using System;

namespace VirtualOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Five", 10);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.MakeSound();
            dog.Eat();
            dog.Play();
        }
    }
}