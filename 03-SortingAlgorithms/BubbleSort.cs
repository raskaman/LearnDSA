using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void Sort(int[] a)
        {
            var stepCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool isAnyChange = false;
                for (int j = 0; j < a.Length -1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        isAnyChange = true;
                        (a[j], a[j + 1]) = (a[j + 1], a[j]);
                    }
                    stepCount += 1;
                    Console.WriteLine($"step {stepCount}, {string.Join("| ", a)}");
                    
                }
                if (!isAnyChange) { break; }
            }
        }
    }
}
