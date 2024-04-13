using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    internal class Solution
    {
        public static int[] CalculateColumnSums(int columns, int rows, int[,] matrix)
        {
            int[] columnSums = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        columnSums[j] += matrix[i, j];
                    }
                }
            }
            return columnSums;
        }
    }
}
