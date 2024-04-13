using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Solution
    {

        public static int GetResult(int[] mas, int k, int l)
        {
            int sum = 0;
            for (int i = k; i <= l; i++)
            {
                sum += mas[i];
            }
            return sum;
        }
    }
}
