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
                    string element = Grid[y, x];
                    Console.SetCursorPosition(x, y);
                    Console.Write(element);
                }
            }
        }

        public bool CheckForBoarder(int x, int y)
        {
            return Grid[y, x] == "─" || Grid[y, x] == "?" || Grid[y, x] == "+" || Grid[y, x] == "│" || Grid[y, x] == " ";
        }

        public bool TestIfAvailableSquare(int x, int y)
        {
            if (y > 10 && y < 22 && x > 10 && x < 28)
            {
                return true;
            }
            else return false;
        }

        //Need to save an array to keep a track on who has what space, 0 would be empty, 1 would be X and 2 would be O


        //Calculate a winner from above code
    }
}
