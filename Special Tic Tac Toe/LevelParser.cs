using System.IO;

namespace Special_Tic_Tac_Toe
{
    internal class LevelParser
    {
        public static string[,] ParseFilesToArray(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int rows = lines.Length;
            int columns = lines[0].Length;
            string[,] grid = new string[rows, columns];
            for (int y = 0; y < rows; y++)
            {
                string line = lines[y];
                for (int x = 0; x < columns; x++)
                {
                    char currentCharacter = line[x];
                    grid[y, x] = currentCharacter.ToString();
                }
            }
            return grid;
        }
    }
}
