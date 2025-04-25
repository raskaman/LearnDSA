public class ShellSort : AbstractSort
{
    /// example array [-11, 12, 13, -15, -4, -9, -13];
    public override void Sort(int[] a)
    {
        for (int gap = a.Length / 2;  /* from example array, on first iteration gap = 7/2 = 3 */
            gap > 0; /* condition gap grather than 0; 1 or bigger */
            gap /= 2 /* decrement gap, second iteration gap = 3/2 = 1, third iteration gap = 1/3 = 0, condition not met */)
        {

            // perform insertion sort, relative to gap
            for (int i = gap; i < a.Length; i++) // iterate each element of the array, starting at gap
            {
                int j = i; // keeps track of the gap element from the for loop
                int ai = a[i]; // get element value located at index gap; i = gap = 3 on first iteration, i = gap = 1 on second iteration

                while (j >= gap && ai < a[j - gap]) // loop the array and compare elements relative to gap
                {
                    a[j] = a[j - gap]; // swap element
                    j -= gap; // reduce j by gap; j = j - gap = 3 - 3 = 0 on first for loop iteration, j = j - gap = 4 - 3 = 1 on second for loop iteration
                    //Console.WriteLine(string.Join("| ", a));
                }
                a[j] = ai; /* swap element */
               // Console.WriteLine(string.Join("| ", a));
            }

            //// commented code: another version of insertion sort
            //// perform insertion sort, relative to gap
            //for (int i = gap; i < a.Length; i++) // iterate each element of the array
            //{
            //    int j = i;
            //    while (j >= gap && a[j] < a[j - gap]) // loop the array and compare elements relative to gap
            //    {
            //        Console.WriteLine(string.Join("| ", a));
            //        (a[j], a[j - gap]) = (a[j - gap], a[j]); // swap elements
            //        j -= gap; // reduce j by gap;
            //    }
            //}
        }


    }
}
