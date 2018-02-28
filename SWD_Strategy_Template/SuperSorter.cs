using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Strategy_Template
{
    public abstract class SuperSorter
    {
        Stopwatch sw = new Stopwatch();
        public bool HasBeenSorted;
        public double StartSort(int[] toBeSorted)
        {
            StartTime();
            Sort(toBeSorted);
            StopTime();
            return sw.Elapsed.TotalMilliseconds;
        }

        public abstract void Sort(int[] toBeSorted);

        public void StartTime()
        {
            sw.Start();
        }

        public void StopTime()
        {
            sw.Stop();
        }
        public override string ToString()
        {
            return "Non-sorted array";
        }

        public void Reset()
        {
            HasBeenSorted = false;
        }

        public void PrintArray(int[] someArray)
        {
            Console.Write("\nPrinting array: {0}\n", this.ToString());
            foreach (var element in someArray)
                Console.Write(element + ", ");
        }
    }

    public class BubbleSort : SuperSorter
    {
        
        public override void Sort(int[] toBeSorted)
        {
            int t = 0;

            for (int write = 0; write < toBeSorted.Length; write++)
            {
                for (int sort = 0; sort < toBeSorted.Length - 1; sort++)
                {
                    if (toBeSorted[sort] > toBeSorted[sort + 1])
                    {
                        t = toBeSorted[sort + 1];
                        toBeSorted[sort + 1] = toBeSorted[sort];
                        toBeSorted[sort] = t;
                    }
                }
            }
            HasBeenSorted = true;
        }
        public override string ToString()
        {
            return HasBeenSorted ? "Bubble sorted array" : "Non-sorted array";
        }
    }

    public class BucketSort : SuperSorter
    {
        public override void Sort(int[] toBeSorted)
        {
            var minValue = toBeSorted[0];
            var maxValue = toBeSorted[0];

            for (var i = 1; i < toBeSorted.Length; i++)
            {
                if (toBeSorted[i] > maxValue)
                    maxValue = toBeSorted[i];
                if (toBeSorted[i] < minValue)
                    minValue = toBeSorted[i];
            }

            var bucket = new List<int>[maxValue - minValue + 1];

            for (var i = 0; i < bucket.Length; i++) bucket[i] = new List<int>();

            foreach (var item in toBeSorted)
                bucket[item - minValue].Add(item);

            var k = 0;
            foreach (var item in bucket)
                if (item.Count > 0)
                    foreach (var intval in item)
                    {
                        toBeSorted[k] = intval;
                        k++;
                    }

            HasBeenSorted = true;
        }
        public override string ToString()
        {
            return HasBeenSorted ? "Bucket sorted array" : "Non-sorted array";
        }
    }


    public class QuickSort : SuperSorter
    {
        public override void Sort(int[] toBeSorted)
        {
            QuicklySort(toBeSorted, 0, toBeSorted.Length - 1);
        }

        private void QuicklySort(IList<int> a, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            var num = a[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && a[j] >= num)
                {
                    j--;
                }

                a[i] = a[j];

                while (i < j && a[i] < num)
                {
                    i++;
                }

                a[j] = a[i];
            }

            a[i] = num;
            QuicklySort(a, start, i - 1);
            QuicklySort(a, i + 1, end);
        }
        public override string ToString()
        {
            return HasBeenSorted ? "Quick sorted array" : "Non-sorted array";
        }
    }
}
