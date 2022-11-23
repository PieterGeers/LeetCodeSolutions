using System;
using System.IO.MemoryMappedFiles;

namespace _733._Flood_Fill
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] array2D = new int[4][];
            array2D[0] = new[] { 1, 1 };
            array2D[1] = new[] { 1, 1 };
            array2D[2] = new[] { 1, 0 };
            array2D[3] = new[] { 0, 1 };
            var result = s.FloodFill(array2D, 1, 1, 2);
        }
    }

    public class Solution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] == color)
            {
                return image;
            }

            int rows = image.Length;
            int columns = rows > 0 ? image[0].Length : 0;
            FloodFill(image, rows, columns, sr, sc, image[sr][sc], color);
            return image;
        }

        public void FloodFill(int[][] image, int rows, int columns, int sr, int sc, int sColor, int dColor)
        {
            if (sr < 0 || sr >= rows || sc < 0 || sc >= columns || image[sr][sc] != sColor)
            {
                return;
            }

            image[sr][sc] = dColor;
            FloodFill(image, rows, columns, sr - 1, sc, sColor, dColor); //up
            FloodFill(image, rows, columns, sr + 1, sc, sColor, dColor); //down
            FloodFill(image, rows, columns, sr, sc - 1, sColor, dColor); //left
            FloodFill(image, rows, columns, sr, sc + 1, sColor, dColor); //right
        }

    }
}
