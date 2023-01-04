using System;


namespace Special_Tic_Tac_Toe
{
    internal class Game
    {

        private World Board;
        private Player Player1;
        private Player Player2;
        bool isXturn = true; //If it's false it's O turn

        public void Start()
        {
            Console.WriteLine("Press any key to start");
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.Clear();

            string[,] grid = LevelParser.ParseFilesToArray("Map.txt");
            Board = new World(grid);



            Player1 = new Player(9, 27, "X");
            Player2 = new Player(29, 27, "O");

            GameLoop();
        }


        private void DrawFrame()
        {

            Board.Draw();
            Player1.Draw();
            Player2.Draw();

        }

        private void PlayerInput()
        {
            ConsoleKey key;
            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;
            } while (Console.KeyAvailable); //This loop makes sure you store key presses.
            switch (key)
            {
                #region player1
                case ConsoleKey.W:
                    if (Board.CheckForBoarder(Player1.X, Player1.Y - 1))
                    {
                        Player1.Y -= 1;
                    }
                    break;

                case ConsoleKey.S:
                    if (Board.CheckForBoarder(Player1.X, Player1.Y + 1))
                    {
                        Player1.Y += 1;
                    }
                    break;

                case ConsoleKey.A:
                    if (Board.CheckForBoarder(Player1.X - 1, Player1.Y))
                    {
                        Player1.X -= 1;
                    }
                    break;

                case ConsoleKey.D:
                    if (Board.CheckForBoarder(Player1.X + 1, Player1.Y))
                    {
                        Player1.X += 1;
                    }
                    break;

                case ConsoleKey.X:
                    if (isXturn == true && Board.TestIfAvailableSquare(Player1.X, Player1.Y)) //Change these to actually check correct places.
                    {
                        Console.WriteLine("Test"); //Test input and turn change X
                        isXturn = false;
                    }
                    break;
                #endregion player1
                #region player2
                case ConsoleKey.UpArrow:
                    if (Board.CheckForBoarder(Player2.X, Player2.Y - 1))
                    {
                        Player2.Y -= 1;
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (Board.CheckForBoarder(Player2.X, Player2.Y + 1))
                    {
                        Player2.Y += 1;
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    if (Board.CheckForBoarder(Player2.X - 1, Player2.Y))
                    {
                        Player2.X -= 1;
                    }
                    break;

                case ConsoleKey.RightArrow:
                    if (Board.CheckForBoarder(Player2.X + 1, Player2.Y))
                    {
                        Player2.X += 1;
                    }
                    break;
                case ConsoleKey.Enter:
                    if (isXturn == false && Board.TestIfAvailableSquare(Player2.X, Player2.Y) == true)
                    {
                        Console.WriteLine("Works"); //Test input and turn change for O
                        isXturn = true;
                    }
                    break;
                #endregion player2
                default:
                    break;
            }
        }

        //

        private void GameLoop()
        {
            while (true)
            {

                //Draw
                DrawFrame();
                //Check input players
                PlayerInput();

            }
        }
    }
}
