public class BubbleSort : AbstractSort
{
    public override void Sort(int[] a)
    {
        var stepCount = 0; // not part of the algorithm, just used to count steps
        for (int i = 0; // start at index 0
            i < a.Length; // condition: iterate until last element
            i++ // increment i by one
            ) // iterate for each element in the array
        {
            bool isAnyChange = false;
            for (int j = 0; // start at index 0
                j < a.Length - 1; // condition: iterate until last element minus one
                j++ // increment j by one
                )  // iterate for each element in the array until one element is left
            {
                if (a[j] > a[j + 1]) // compare adjadcent elements
                {
                    isAnyChange = true;
                    (a[j], a[j + 1]) = (a[j + 1], a[j]); // swap elements
                }
                stepCount += 1;
                //Console.WriteLine($"step {stepCount}, {string.Join("| ", a)}");

            }
            if (!isAnyChange) { break; } // perfomance improvement
        }
    }
}
