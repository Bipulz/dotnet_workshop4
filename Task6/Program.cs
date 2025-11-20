namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Task 6");

            Console.Write("Enter your obtained marks: ");
            string marksInput = Console.ReadLine();

            Console.Write("Enter the full marks: ");
            string totalInput = Console.ReadLine();

            int obtained;
            int maximum;

            bool validMarks = int.TryParse(marksInput, out obtained);
            bool validTotal = int.TryParse(totalInput, out maximum);

            if (!validMarks || !validTotal)
            {
                Console.WriteLine("Error: Please type valid whole numbers.");
                return;
            }

            double percent = (double)obtained / maximum * 100;

            Console.WriteLine($"Your percentage is {percent}");
            Console.ReadLine();
        }
    }
}
