namespace SnakeAndLadder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start game at 0 Position");
            Game game = new Game();
            game.StartTheGame();
        }
    }
}