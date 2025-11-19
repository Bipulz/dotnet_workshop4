using System;

namespace task2
{
    internal class Calculator
    {
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Simple Calculator!");
        }

        public int Add(int num1, int num2)
        {
            // returns the sum of two numbers
            return num1 + num2;
        }

        public int Multiply(int num1, int num2 = 5)
        {
            // multiplies with default value if second number is not provided
            return num1 * num2;
        }
    }
}
