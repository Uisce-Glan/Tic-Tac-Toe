using System;

namespace Special_Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testIfPlayAgain;
            var playAgain = true;
            if (playAgain = true)
            {
                Game currentGame = new Game();
                currentGame.Start();
                Console.Clear();
                Console.WriteLine("Do you wish to play again? \n\nYes     No");
                testIfPlayAgain = Console.ReadLine();
                if (testIfPlayAgain == "No" || testIfPlayAgain == "no")
                {
                    playAgain = false;
                }
            }
        }
    }
}
