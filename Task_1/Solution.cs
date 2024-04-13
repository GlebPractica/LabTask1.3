using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Solution
    {

        public static int[] GenerateArithmeticProgression(int N, int A, int D)
        {
            int[] progression = new int[N];
            for (int i = 0; i < N; i++)
            {
                progression[i] = A + i * D;
            }
            return progression;
        }
    }
}
