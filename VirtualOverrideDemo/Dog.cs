using System;
namespace VirtualOverrideDemo
{
    //Calling parent class
    public class Dog : Animal
    {
        //bool property to check if the dog is happy.
        public bool IsHappy { get; set; }

        //Simple constructor to pass the name and age of the animal to the base constructor
        public Dog(string name, int age) : base(name, age)
        {
            //all dogs are happy

            IsHappy = true;
        }

        //simple override of the virtual method Eat.
        public override void Eat()
        {
            //to call the eat method from our base class we use the keyword "base"
            base.Eat();
        }

        //override the virtual method of makesound

        public override void MakeSound()
        {
            //Since each animal will make a total different sound
            //Each animal will make their own version of MakeSound
            Console.WriteLine("Wuuuuufff");
        }

        //override the virtual method of play

        public override void Play()
        {
            //check if the Dog is happy, if so, dog play.
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
