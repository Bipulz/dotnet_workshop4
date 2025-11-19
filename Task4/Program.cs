namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Task 4!");

            Player player1 = new Player();
            player1.playerName = "Hero Boss";
            player1.level = 1;
            player1.health = "Stable";

            Player player2 = new Player("Kiran Lama", 50, "Excellent");

            Console.WriteLine($"Player 1 → Name: {player1.playerName}, Level: {player1.level}, Health: {player1.health}");
            Console.WriteLine();
            Console.WriteLine($"Player 2 → Name: {player2.playerName}, Level: {player2.level}, Health: {player2.health}");
        }
    }
}
