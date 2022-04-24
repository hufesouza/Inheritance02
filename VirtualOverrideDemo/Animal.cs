using System;
namespace VirtualOverrideDemo
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal (string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        //Virtual method called MakeSound which sub classes can override
        public virtual void MakeSound()
        {
           
        }
        //Virtual method called eat which sub classes can override
        public virtual void Eat()
        {
            //check is the animal is hungry
            if (IsHungry)
            {
                //if so, print on the console the following message
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                // if not hungry, print on the console the following message
                Console.WriteLine($"{Name} is not eating");
            }
        }
        //Virtual method called play which sub classes can override
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }

    }
}
