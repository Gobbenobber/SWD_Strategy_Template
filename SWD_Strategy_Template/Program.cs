using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Strategy_Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keke = new RandomArrayGenerator().GenerateArray(1000, 32);
            Console.WriteLine("===========\tUsing bubble sort\t===========");
            SuperSorter bsorter = new BubbleSort();
            bsorter.PrintArray(keke);
            var timeToBubbleSort = bsorter.StartSort(keke);
            bsorter.PrintArray(keke);
            Console.WriteLine("\nTime elapsed: {0} ms", timeToBubbleSort);

            int[] kek = new RandomArrayGenerator().GenerateArray(1000, 42);
            Console.WriteLine("\n===========\tUsing bucket sort\t===========");
            SuperSorter bucketSorter = new BucketSort();
            //bucketSorter.PrintArray(kek);
            var timeToBucketSort = bucketSorter.StartSort(kek);
            //bucketSorter.PrintArray(kek);
            Console.WriteLine("\nTime elapsed: {0} ms", timeToBucketSort);

            int[] dank = new ReverseOrderArrayGenerator().GenerateArray(5000000);
            Console.WriteLine("\n===========\tUsing bucket sort\t===========");
            bucketSorter.Reset();
            //bucketSorter.PrintArray(dank);
            var timeToReverseBucketSort = bucketSorter.StartSort(dank);
            //bucketSorter.PrintArray(dank);
            Console.WriteLine("\nTime elapsed: {0} ms", timeToReverseBucketSort);
        }
    }
}
