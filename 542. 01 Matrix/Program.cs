using System;
using System.Collections.Generic;

namespace _542._01_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] input = new int[10][];
            input[0] = new [] { 0, 0, 1, 0, 1, 1, 1, 0, 1, 1 };
            input[1] = new [] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 };
            input[2] = new [] { 1, 1, 1, 1, 1, 0, 0, 0, 1, 1 };
            input[3] = new [] { 1, 0, 1, 0, 1, 1, 1, 0, 1, 1 };
            input[4] = new [] { 0, 0, 1, 1, 1, 0, 1, 1, 1, 1 };
            input[5] = new [] { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
            input[6] = new [] { 1, 1, 1, 1, 0, 1, 0, 1, 0, 1 };
            input[7] = new [] { 0, 1, 0, 0, 0, 1, 0, 0, 1, 1 };
            input[8] = new [] { 1, 1, 1, 0, 1, 1, 0, 1, 0, 1 };
            input[9] = new [] { 1, 0, 1, 1, 1, 0, 1, 1, 1, 0 };

            var result = s.UpdateMatrix(input);
        }
    }

    public class Solution
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            int rows = mat.Length;
            int columns = rows > 0 ? mat[0].Length : 0;

            Dictionary<int, List<int>> zeroPositions = new Dictionary<int, List<int>>();

            for (int i = 0, j; i < rows; i++)
            {
                List<int> zeros = new List<int>();
                for (j = 0; j < columns; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        zeros.Add(j);
                    }
                }
                zeroPositions.Add(i, zeros);
            }

            for (int i = 0, j, k; i < rows; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        continue;
                    }

                    int sameRowClosest = int.MaxValue;
                    int aboveRowClosest = int.MaxValue;
                    int belowRowClosest = int.MaxValue;

                    sameRowClosest = FindClosestDistance(i, zeroPositions[i], i, j);

                    for (k = i - 1; k >= 0; k--)
                    {
                        aboveRowClosest = Math.Min(aboveRowClosest, FindClosestDistance(k, zeroPositions[k], i, j));
                        if (aboveRowClosest <= Math.Abs(i - k) || sameRowClosest <= Math.Abs(i - k)) break;
                    }

                    for (k = i + 1; k < rows; k++)
                    {
                        belowRowClosest = Math.Min(belowRowClosest, FindClosestDistance(k, zeroPositions[k], i, j));
                        if (belowRowClosest <= Math.Abs(i - k) || sameRowClosest <= Math.Abs(i - k)) break;
                    }

                    mat[i][j] = Math.Min(sameRowClosest, Math.Min(belowRowClosest, aboveRowClosest));
                }
            }


            return mat;
        }

        private int FindClosestDistance(int rowIdx, List<int> columnIdxList, int rowPos, int columnPos)
        {
            if (columnIdxList.Count == 0)
            {
                return int.MaxValue;
            }

            int closestDistance = int.MaxValue;
            foreach (int i in columnIdxList)
            {
                closestDistance = Math.Min(closestDistance, Math.Abs(rowPos - rowIdx) + Math.Abs(columnPos - i));
            }

            return closestDistance;
        }
    }
}
