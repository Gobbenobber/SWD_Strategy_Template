using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Strategy_Template
{
    interface IArrayGenerator
    {
        int[] GenerateArray(int n, int seed = 0);
    }

    public class RandomArrayGenerator : IArrayGenerator
    {
        public int[] GenerateArray(int n, int seed = 0)
        {
            Random rg = new Random(seed);
            int[] randArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                randArray[i] = rg.Next(0,n);
            }
            return randArray;
        }
    }

    public class ReverseOrderArrayGenerator : IArrayGenerator
    {
        public int[] GenerateArray(int n, int seed = 0)
        {
            int[] rorderArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                rorderArray[i] = n-i-1;
            }
            return rorderArray;
        }
    }

    public class NearlySortedArrayGenerator : IArrayGenerator
    {
        public int[] GenerateArray(int n, int seed)
        {
            Random random = new Random(seed);
            int[] nearlySortedArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i % 5 == 0)
                {
                    nearlySortedArray[i] = random.Next(0, n);
                }
                else
                    nearlySortedArray[i] = i;
            }

            return nearlySortedArray;
        }
    }

}
