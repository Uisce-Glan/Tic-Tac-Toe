using System;
using System.Threading;

namespace Special_Tic_Tac_Toe
{
    internal class Game
    {

        private World Board;
        private Player Player1;
        private Player Player2;
        bool isXturn = true; //If it's false it's O turn
        public int is1occupied = 0; //These are numbered after the keypad so bottom left is 1 and top right is 9
        int is2occupied = 0;
        int is3occupied = 0; // they are also integers so i can keep track if its X (1) or O (2) that occupies the space
        int is4occupied = 0;
        int is5occupied = 0;
        int is6occupied = 0;
        int is7occupied = 0;
        int is8occupied = 0;
        int is9occupied = 0;


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
            } while (Console.KeyAvailable); //This loop makes sure you don't store key presses.
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
                    if (isXturn == true) //Change these to actually check correct places.
                    {
                        #region Placing X
                        if (is1occupied == 0 && Board.Square1(Player1.X, Player1.Y) == true)
                        {
                            isXturn = false;
                            is1occupied = 1;
                            Board.score[2, 0] = 1;
                        }
                        if (is2occupied == 0 && Board.Square2(Player1.X, Player1.Y) == true)
                        {
                            isXturn = false;
                            is2occupied = 1;
                            Board.score[2, 1] = 1;
                        }
                        if (is3occupied == 0 && Board.Square3(Player1.X, Player1.Y) == true)
                        {
                            isXturn = false;
                            is3occupied = 1;
                            Board.score[2, 2] = 1;
                        }
                        if (is4occupied == 0 && Board.Square4(Player1.X, Player1.Y) == true)
                        {
                            isXturn = false;
                            is4occupied = 1;
                            Board.score[1, 0] = 1;
                        }
                        if (is5occupied == 0 && Board.Square5(Player1.X, Player1.Y) == true)
                        {
                            isXturn = false;
                            is5occupied = 1;
                            Board.score[1, 1] = 1;
                        }
                        if (is6occupied == 0 && Board.Square6(Player1.X, Player1.Y) == true)
                        {
                            isXturn = false;
                            is6occupied = 1;
                            Board.score[1, 2] = 1;
                        }
                        if (is7occupied == 0 && Board.Square7(Player1.X, Player1.Y) == true)
                        {
                            isXturn = false;
                            is7occupied = 1;
                            Board.score[0, 0] = 1;
                        }
                        if (is8occupied == 0 && Board.Square8(Player1.X, Player1.Y) == true)
                        {
                            isXturn = false;
                            is8occupied = 1;
                            Board.score[0, 1] = 1;
                        }
                        if (is9occupied == 0 && Board.Square9(Player1.X, Player1.Y) == true)
                        {
                            isXturn = false;
                            is9occupied = 1;
                            Board.score[0, 2] = 1;
                        }
                        #endregion Placing X

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
                    if (isXturn == false)
                    {
                        #region Placing O
                        if (is1occupied == 0 && Board.Square1(Player2.X, Player2.Y) == true)
                        {
                            isXturn = true;
                            is1occupied = 2;
                            Board.score[2, 0] = 2;
                        }
                        if (is2occupied == 0 && Board.Square2(Player2.X, Player2.Y) == true)
                        {
                            isXturn = true;
                            is2occupied = 2;
                            Board.score[2, 1] = 2;
                        }
                        if (is3occupied == 0 && Board.Square3(Player2.X, Player2.Y) == true)
                        {
                            isXturn = true;
                            is3occupied = 2;
                            Board.score[2, 2] = 2;
                        }
                        if (is4occupied == 0 && Board.Square4(Player2.X, Player2.Y) == true)
                        {
                            isXturn = true;
                            is4occupied = 2;
                            Board.score[1, 0] = 2;
                        }
                        if (is5occupied == 0 && Board.Square5(Player2.X, Player2.Y) == true)
                        {
                            isXturn = true;
                            is5occupied = 2;
                            Board.score[1, 1] = 2;
                        }
                        if (is6occupied == 0 && Board.Square6(Player2.X, Player2.Y) == true)
                        {
                            isXturn = true;
                            is6occupied = 2;
                            Board.score[1, 2] = 2;
                        }
                        if (is7occupied == 0 && Board.Square7(Player2.X, Player2.Y) == true)
                        {
                            isXturn = true;
                            is7occupied = 2;
                            Board.score[0, 0] = 2;
                        }
                        if (is8occupied == 0 && Board.Square8(Player2.X, Player2.Y) == true)
                        {
                            isXturn = true;
                            is8occupied = 2;
                            Board.score[0, 1] = 2;
                        }
                        if (is9occupied == 0 && Board.Square9(Player2.X, Player2.Y) == true)
                        {
                            isXturn = true;
                            is9occupied = 2;
                            Board.score[0, 2] = 2;
                        }
                        #endregion Placing O
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
                //Check victory condition
                if (Board.CheckIfOWin() == true)
                {
                    Console.Clear();
                    Console.WriteLine("O Wins");
                    Thread.Sleep(5000); //Makes sure no one clicks past the "O Wins"
                    Console.ReadLine();
                    break;
                }
                if (Board.CheckIfXWin() == true)
                {
                    Console.Clear();
                    Console.WriteLine("X Wins");
                    Thread.Sleep(5000);//Makes sure no one clicks past the "X Wins"
                    Console.ReadLine();
                    break;
                }
            }
        }

    }
}
