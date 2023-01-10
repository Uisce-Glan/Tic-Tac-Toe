using System;

namespace Special_Tic_Tac_Toe
{
    internal class World
    {
        private string[,] Grid;
        private int Rows;
        private int Columns;

        public World(string[,] grid)
        {
            Grid = grid;
            Rows = grid.GetLength(0);
            Columns = grid.GetLength(1);
        }

        public void Draw()
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Columns; x++)
                {
                    #region Being able to have an "currentPlayer" would be useful here as well
                    if (score[0, 0] == 1 && y == 12 && x == 13)
                    {
                        Console.Write("X");
                        continue;
                    }
                    if (score[0, 0] == 2 && y == 12 && x == 13)
                    {
                        Console.Write("O");
                        continue;
                    }
                    if (score[0, 1] == 1 && y == 12 && x == 19)
                    {
                        Console.Write("X");
                        continue;
                    }
                    if (score[0, 1] == 2 && y == 12 && x == 19)
                    {
                        Console.Write("O");
                        continue;
                    }
                    if (score[0, 2] == 1 && y == 12 && x == 25)
                    {
                        Console.Write("X");
                        continue;
                    }
                    if (score[0, 2] == 2 && y == 12 && x == 25)
                    {
                        Console.Write("O");
                        continue;
                    }
                    if (score[1, 0] == 1 && y == 16 && x == 13)
                    {
                        Console.Write("X");
                        continue;
                    }
                    if (score[1, 0] == 2 && y == 16 && x == 13)
                    {
                        Console.Write("O");
                        continue;
                    }
                    if (score[1, 1] == 1 && y == 16 && x == 19)
                    {
                        Console.Write("X");
                        continue;
                    }
                    if (score[1, 1] == 2 && y == 16 && x == 19)
                    {
                        Console.Write("O");
                        continue;
                    }
                    if (score[1, 2] == 1 && y == 16 && x == 25)
                    {
                        Console.Write("X");
                        continue;
                    }
                    if (score[1, 2] == 2 && y == 16 && x == 25)
                    {
                        Console.Write("O");
                        continue;
                    }
                    if (score[2, 0] == 1 && y == 20 && x == 13)
                    {
                        Console.Write("X");
                        continue;
                    }
                    if (score[2, 0] == 2 && y == 20 && x == 13)
                    {
                        Console.Write("O");
                        continue;
                    }
                    if (score[2, 1] == 1 && y == 20 && x == 19)
                    {
                        Console.Write("X");
                        continue;
                    }
                    if (score[2, 1] == 2 && y == 20 && x == 19)
                    {
                        Console.Write("O");
                        continue;
                    }
                    if (score[2, 2] == 1 && y == 20 && x == 25)
                    {
                        Console.Write("X");
                        continue;
                    }
                    if (score[2, 2] == 2 && y == 20 && x == 25)
                    {
                        Console.Write("O");
                        continue;
                    }
                    #endregion Being able to have an "currentPlayer[marker]" would be useful here as well
                    string element = Grid[y, x];
                    Console.SetCursorPosition(x, y);
                    Console.Write(element);

                }
            }
        }
        /// <summary>
        /// Checks if you can walk here
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool CheckForBoarder(int x, int y)
        {
            return Grid[y, x] == "─" || Grid[y, x] == "?" || Grid[y, x] == "+" || Grid[y, x] == "│" || Grid[y, x] == " "; // These should be walkable
        }


        #region Check if within squares
        public bool Square1(int x, int y) //These are numbered after the keypad so bottom left is 1 and top right is 9
        {
            if (y > 18 && y < 22 && x > 10 && x < 16)
            {
                return true;
            }
            else return false;
        }
        public bool Square2(int x, int y) //Bot Middle
        {
            if (y > 18 && y < 22 && x > 16 && x < 22)
            {
                return true;
            }
            else return false;
        }
        public bool Square3(int x, int y) // Bot right
        {
            if (y > 18 && y < 22 && x > 22 && x < 28)
            {
                return true;
            }
            else return false;
        }
        public bool Square4(int x, int y) // Mid left
        {
            if (y > 14 && y < 18 && x > 10 && x < 16)
            {
                return true;
            }
            else return false;
        }
        public bool Square5(int x, int y) // Mid mid
        {
            if (y > 14 && y < 18 && x > 16 && x < 22)
            {
                return true;
            }
            else return false;
        }
        public bool Square6(int x, int y) // Mid right
        {
            if (y > 14 && y < 18 && x > 22 && x < 28)
            {
                return true;
            }
            else return false;
        }
        public bool Square7(int x, int y) // Top left
        {
            if (y > 10 && y < 14 && x > 10 && x < 16)
            {
                return true;
            }
            else return false;
        }
        public bool Square8(int x, int y) // Top mid
        {
            if (y > 10 && y < 14 && x > 16 && x < 22)
            {
                return true;
            }
            else return false;
        }
        public bool Square9(int x, int y) // Top right
        {
            if (y > 10 && y < 14 && x > 22 && x < 28)
            {
                return true;
            }
            else return false;
        }
        #endregion Check if within squares

        // vvv tracks where stuff is placed 0 = no one has placed, 1 = x has placed, 2 = O has placed
        public int[,] score = new int[3, 3] {
            {0, 0, 0} ,
            {0, 0 ,0} ,
            {0, 0 ,0}
        };

        /// <summary>
        /// Check if player O won
        /// </summary>
        /// <returns></returns> Returns true if player alligned 3 O in a row
        public bool CheckIfOWin() //modified versions of https://stackoverflow.com/a/21370106
        {
            // check rows
            if (score[0, 0] == 2 && score[0, 1] == 2 && score[0, 2] == 2) { return true; }
            if (score[1, 0] == 2 && score[1, 1] == 2 && score[1, 2] == 2) { return true; }
            if (score[2, 0] == 2 && score[2, 1] == 2 && score[2, 2] == 2) { return true; }

            // check columns
            if (score[0, 0] == 2 && score[1, 0] == 2 && score[2, 0] == 2) { return true; }
            if (score[0, 1] == 2 && score[1, 1] == 2 && score[2, 1] == 2) { return true; }
            if (score[0, 2] == 2 && score[1, 2] == 2 && score[2, 2] == 2) { return true; }

            // check diags
            if (score[0, 0] == 2 && score[1, 1] == 2 && score[2, 2] == 2) { return true; }
            if (score[0, 2] == 2 && score[1, 1] == 2 && score[2, 0] == 2) { return true; }

            return false;
        }
        /// <summary>
        /// Check if player X won
        /// </summary>
        /// <returns></returns> Returns true if player alligned 3 X in a row
        public bool CheckIfXWin()
        {
            // check rows
            if (score[0, 0] == 1 && score[0, 1] == 1 && score[0, 2] == 1) { return true; }
            if (score[1, 0] == 1 && score[1, 1] == 1 && score[1, 2] == 1) { return true; }
            if (score[2, 0] == 1 && score[2, 1] == 1 && score[2, 2] == 1) { return true; }

            // check columns
            if (score[0, 0] == 1 && score[1, 0] == 1 && score[2, 0] == 1) { return true; }
            if (score[0, 1] == 1 && score[1, 1] == 1 && score[2, 1] == 1) { return true; }
            if (score[0, 2] == 1 && score[1, 2] == 1 && score[2, 2] == 1) { return true; }

            // check diags
            if (score[0, 0] == 1 && score[1, 1] == 1 && score[2, 2] == 1) { return true; }
            if (score[0, 2] == 1 && score[1, 1] == 1 && score[2, 0] == 1) { return true; }
            return false;
        }
    }
}
