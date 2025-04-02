using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SortingAlgorithms
{
   public static class ShellSort
    {
        /// example array [-11, 12, 13, -15, -4, -9, -13];
        public static void Sort(int[] a) 
        {
            for (int h = a.Length / 2;  /* from example array, on first iteration h = 7/2 = 3 */
                h > 0; /* condition h grather than 0 */
                h /= 2 /* decrement h, second iteration h = 3/2 = 1, third iteration h = 1/3 = 0 */)
            {

                // perform insertion sort, relative to h
                for (int i = h; i < a.Length; i++) // iterate each element of the array
                {
                    int j = i; // keeps track of the latest element in the for loop
                    int ai = a[i]; // get element located at h; i = h = 3 on first iteration, i = h = 1 on second iteration

                    while (j >= h && ai < a[j - h]) // loop the array and compare elements relative to h
                    {
                        a[j] = a[j - h]; // swap element
                        j -= h; // reduce j by h; j = j - h = 3 - 3 = 0 on first for loop iteration, j = j - h = 4 - 3 = 1 on second for loop iteration
                        Console.WriteLine(string.Join("| ", a));
                    }
                    a[j] = ai; /* swap element */
                    Console.WriteLine(string.Join("| ", a));
                }

                //// commented code: another version of insertion sort
                //// perform insertion sort, relative to h
                //for (int i = h; i < a.Length; i++) // iterate each element of the array
                //{
                //    int j = i;
                //    while (j >= h && a[j] < a[j - h]) // loop the array and compare elements relative to h
                //    {
                //        Console.WriteLine(string.Join("| ", a));
                //        (a[j], a[j - h]) = (a[j - h], a[j]); // swap elements
                //        j -= h; // reduce j by h;
                //    }
                //}
            }


        }
    }
}
