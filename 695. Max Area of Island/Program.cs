using System;
using System.Collections.Specialized;

namespace _695._Max_Area_of_Island
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] input = new int[8][];
            input[0] = new[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 };
            input[1] = new[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 };
            input[2] = new[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 };
            input[3] = new[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 };
            input[4] = new[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 };
            input[5] = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 };
            input[6] = new[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 };
            input[7] = new[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 };
            var result = s.MaxAreaOfIsland(input);
        }
    }

    public class Solution
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            int i, j, result = 0;

            int rows = grid.Length;
            int columns = rows > 0 ? grid[0].Length : 0;

            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        continue;
                    }

                    result = Math.Max(result, FloodFill(grid, rows, columns, i, j));
                }
            }

            return result;
        }

        private int FloodFill(int[][] grid, int rows, int columns, int sr, int sc)
        {
            if (sr < 0 || sr >= rows || sc < 0 || sc >= columns || grid[sr][sc] == 0)
            {
                return 0;
            }

            grid[sr][sc] = 0;
            return 1 + FloodFill(grid, rows, columns, sr - 1, sc) + //up
                   FloodFill(grid, rows, columns, sr + 1, sc) + //down
                   FloodFill(grid, rows, columns, sr, sc - 1) + //left
                   FloodFill(grid, rows, columns, sr, sc + 1); //right
        }
    }
}
