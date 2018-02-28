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
            //Random order

            var keke = new RandomArrayGenerator().GenerateArray(1000, 32);
            Console.WriteLine("===========\tUsing bubble sort\t===========");
            SuperSorter bsorter = new BubbleSort();
            //bsorter.PrintArray(keke);
            var timeToBubbleSort = bsorter.StartSort(keke);
            //bsorter.PrintArray(keke);
            Console.WriteLine("\nTime elapsed: {0} ms", timeToBubbleSort);

            var kek = new RandomArrayGenerator().GenerateArray(1000, 42);
            Console.WriteLine("\n===========\tUsing bucket sort\t===========");
            SuperSorter bucketSorter = new BucketSort();
            //bucketSorter.PrintArray(kek);
            var timeToBucketSort = bucketSorter.StartSort(kek);
            //bucketSorter.PrintArray(kek);
            Console.WriteLine("\nTime elapsed: {0} ms", timeToBucketSort);

            //Reverse order

            var dank = new ReverseOrderArrayGenerator().GenerateArray(9000);
            Console.WriteLine("\n===========\tUsing Quick sort\t===========");
            //bucketSorter.Reset();
            //bucketSorter.PrintArray(dank);
            var quicksorter = new QuickSort();
            var timeToReverseBucketSort = quicksorter.StartSort(dank);
            //bucketSorter.PrintArray(dank);
            Console.WriteLine("\nTime elapsed: {0} ms", timeToReverseBucketSort);

            //Ordered 

            var dankk = new OrderedArrayGenerator().GenerateArray(9000);
            Console.WriteLine("\n===========\tUsing bucket sort with OrderedArrayGenerator\t===========");
            bucketSorter.Reset();
            //bucketSorter.PrintArray(dankk);
            var timeToBucketSortSortedArray = bucketSorter.StartSort(dankk);
            //bucketSorter.PrintArray(dankk);
            Console.WriteLine("\nTime elapsed: {0} ms", timeToBucketSortSortedArray);
        }
    }
}
