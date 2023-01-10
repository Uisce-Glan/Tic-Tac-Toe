using static System.Console;

namespace Special_Tic_Tac_Toe
{
    internal class Player
    {

        public int X { get; set; }
        public int Y { get; set; }
        private string playerCharacter;



        public Player(int initialX, int initialY, string visiblePlayer) //visiblePlayer is the character that represents the player
        {
            X = initialX;
            Y = initialY;

            playerCharacter = visiblePlayer;
        }


        public void Draw()
        {
            SetCursorPosition(X, Y);
            Write(playerCharacter);
        }
    }
}
