using System;

namespace Polymor
{
    
    class Creature
    {
        
        public virtual void Speak()
        {
            Console.WriteLine("The creature makes an indistinct sound.");
        }
    }

    
    class Dog : Creature
    {
        
        public override void Speak()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    
    class Cat : Creature
    {
        
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }

    
    class Cow : Creature
    {
        
        public override void Speak()
        {
            Console.WriteLine("Moo!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Creature[] creatures = new Creature[]
            {
                new Creature(), 
                new Dog(),       
                new Cat(),       
                new Cow()        
            };

            
            foreach (var creature in creatures)
            {
                creature.Speak();
            }

            
            Console.ReadLine();
        }
    }
}
