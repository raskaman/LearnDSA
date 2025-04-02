using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SortingAlgorithms
{
    public static class InsertionSort
    {
        public static void Sort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int j = i;
                while (j > 0 && a[j] < a[j - 1])
                {

                    Console.WriteLine(string.Join("| ", a));
                    (a[j], a[j - 1]) = (a[j - 1], a[j]);
                    j--;
                }
            }
        }
    }
}
