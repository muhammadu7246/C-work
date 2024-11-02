using System;

namespace SimpleAdd
{
    class Calculator
    {
        // Addition
        public void AddNumbers()
        {
            Console.Write("Addition:\n");
            Console.Write("===========\n");
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");

            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");
        }

        // Subtraction
        public void SubtractNumbers()
        {
            Console.Write("Subtraction:\n");
            Console.Write("===========\n");

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int difference = num1 - num2;
            Console.WriteLine($"The difference of {num1} and {num2} is {difference}.");
        }

        // Multiplication
        public void MultiplyNumbers()
        {
            Console.Write("Multiplication:\n");
            Console.Write("===========\n");

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int product = num1 * num2;
            Console.WriteLine($"The product of {num1} and {num2} is {product}.");
        }

        // Division
        public void DivideNumbers()
        {
            Console.Write("division:\n");
            Console.Write("===========\n");

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            double quotient = (double)num1 / num2;
            Console.WriteLine($"The quotient of {num1} and {num2} is {quotient}.");

            
        }
    }

    // public name()
    // {
       //     Console.WriteLine("Hamza");
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            calculator.AddNumbers();
            calculator.SubtractNumbers();
            calculator.MultiplyNumbers();
            calculator.DivideNumbers();
            Console.ReadKey();
        }
    }
}
