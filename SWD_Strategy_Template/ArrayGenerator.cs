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
            var rg = new Random(seed);
            var randArray = new int[n];
            for (var i = 0; i < n; i++)
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
            var rorderArray = new int[n];
            for (var i = 0; i < n; i++)
            {
                rorderArray[i] = n-i-1;
            }
            return rorderArray;
        }
    }

    public class OrderedArrayGenerator : IArrayGenerator
    {
        public int[] GenerateArray(int n, int seed = 0)
        {
            var orderedArray = new int[n];
            for (var i = 0; i < n; i++)
            {
                orderedArray[i] = i;
            }
            return orderedArray;
        }
    }

    public class NearlySortedArrayGenerator : IArrayGenerator
    {
        public int[] GenerateArray(int n, int seed)
        {
            var random = new Random(seed);
            var nearlySortedArray = new int[n];

            for (var i = 0; i < n; i++)
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
