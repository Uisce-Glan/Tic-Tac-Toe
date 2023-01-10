using System;

namespace Special_Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testIfPlayAgain;
            var playAgain = true;
            do
            {
                Game currentGame = new Game();
                currentGame.Start();
                Console.Clear();
                Console.WriteLine("If you don't want to play again write Exit");
                testIfPlayAgain = Console.ReadLine();
                if (testIfPlayAgain == "Exit" || testIfPlayAgain == "exit")
                {
                    playAgain = false;
                }
                Console.Clear();
            } while (playAgain);
        }
    }
}
