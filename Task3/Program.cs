namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Task 3!");

            ParameterDemo demo = new ParameterDemo();

            int value = 5;
            Console.WriteLine($"Original value: {value}");
            int increasedValue = demo.Increase(ref value);
            Console.WriteLine($"Value after Increase(): {increasedValue}");

            demo.GetFullName(out string fullName);
            Console.WriteLine("Full Name: " + fullName);

            int sum = demo.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine("Sum of all numbers: " + sum);
        }
    }
}
