using System;

namespace Abstraction
{
    public abstract class Vehicle
    {
        public abstract void StartEngine();
        public abstract void StopEngine();
    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("The hourse is running");
        }

        public override void StopEngine()
        {
            Console.WriteLine("The hourse is dei");
        }

        public override string ToString()
        {
            return "This is a Simple Hourse Story";
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("The hourse is running on ground");
        }

        public override void StopEngine()
        {
            Console.WriteLine("The hourse is die after winning");
        }

        public override string ToString()
        {
            return "Simple Story";
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle myCar = new Car();
            Console.WriteLine(myCar);
            myCar.StartEngine();
            myCar.StopEngine();

            Vehicle myBike = new Motorcycle();
            Console.WriteLine(myBike);
            myBike.StartEngine();
            myBike.StopEngine();

            Console.ReadKey();
        }
    }
}
