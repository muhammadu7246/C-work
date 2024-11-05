using System;

namespace Inheritance
{
    
    class Car
    {
        public string Name;
        public string Model;
        public int Price;
        public string Speed;
    }

    
    class CarName : Car
    {
        public void DisplayCarName()
        {
            Console.WriteLine($"My car, the {Name}, is not just a mode of transportation but a true performance machine.");
        }
    }

    
    class CarModel : Car
    {
        public void DisplayCarModel()
        {
            Console.WriteLine($"Making it perfect for those who crave both luxury and power. The {Model} model, known for its sleek design and advanced features, combines cutting-edge technology with unmatched driving dynamics.");
        }
    }

    
    class CarPrice : Car
    {
        public void DisplayCarPrice()
        {
            Console.WriteLine($"With a price tag of around ${Price}.");
        }
    }

    
    class CarSpeed : Car
    {
        public void DisplayCarSpeed()
        {
            Console.WriteLine($"It delivers an impressive top speed of {Speed} mph.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            CarName carName = new CarName();
            CarModel carModel = new CarModel();
            CarPrice carPrice = new CarPrice();
            CarSpeed carSpeed = new CarSpeed();

            
            carName.Name = "Honda";
            carModel.Model = "GLI";
            carPrice.Price = 75000;
            carSpeed.Speed = "400";

            
            carName.DisplayCarName();
            carModel.DisplayCarModel();
            carPrice.DisplayCarPrice();
            carSpeed.DisplayCarSpeed();

            Console.ReadKey();
        }
    }
}
