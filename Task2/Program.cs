namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Task 2!");

            Calculator calculator = new Calculator();

            calculator.PrintWelcome();

            int sum = calculator.Add(10, 20);
            Console.WriteLine($"Sum Result: {sum}");

            int product = calculator.Multiply(10);
            Console.WriteLine($"Product Result: {product}");
        }
    }
}
