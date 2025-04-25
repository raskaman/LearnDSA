public class QuickSort : AbstractSort
{
    static int step = 1;
    public override void Sort(int[] a)
    {
        SortPart(a, 0, a.Length - 1);
        //Console.WriteLine($"step {step}, {string.Join("| ", a)}");
    }

    private static void SortPart(int[] a, int lowerIndex, int upperIndex)
    {

        if (upperIndex > 0 && lowerIndex <= upperIndex)  // for logging purposes, print sub array to console, increment step
        {
            LogSubArray(a, lowerIndex, upperIndex);
        }

        if (lowerIndex >= upperIndex) { return; } // checks if the a array has a least 2 elements, otherwise returns

        int pivot = a[upperIndex]; // stores value of upper element in the a array as the pivot
        int j = lowerIndex - 1; // keeps track of the previous element index

        for (int i = lowerIndex; // start at lower element index
            i < upperIndex; // condition: until upper element index
            i++ // increment by 1
            ) // sort a array with elements smaller than pivot before, and bigger after
        {
            if (a[i] < pivot) // checks if element value is less than pivot value
            {
                j++; // increment by 1 
                (a[j], a[i]) = (a[i], a[j]); // swap elements
                                             //Console.WriteLine($"original array, {string.Join("| ", a)}");
                if (a[i] != a[j])  // for logging purposes, print sub array to console, increment step
                {
                    LogSubArray(a, lowerIndex, upperIndex);
                }
            }
        }
        int p = j + 1; // new index of the pivot value
        (a[p], a[upperIndex]) = (a[upperIndex], a[p]); // swap elements, place the new pivot in place

        if (a[p] != a[upperIndex]) // for logging purposes, print sub array to console, increment step
        {
            LogSubArray(a, lowerIndex, upperIndex);
        }

        SortPart(a, lowerIndex, p - 1);
        SortPart(a, p + 1, upperIndex);
    }

    private static void LogSubArray(int[] a, int lowerIndex, int upperIndex)
    {
        //var sub = GetSubarray(a, lowerIndex, upperIndex);
        //Console.WriteLine($"step {step}, {string.Join("| ", sub)}");
        step++;
    }

    // not part of QuickSort Algorithm, only for logging purposes
    // returns a subarray at specified start and end items
    private static int[] GetSubarray(int[] a, int startItem, int endItem)
    {
        var length = endItem - startItem + 1; // size of new array
        int[] resultArray = new int[length]; // instanciate a new array of size required
        Array.Copy(a, // source array
            startItem, // sourceIndex: starting at the source index
            resultArray, // destination array
            0, // destinationIndex: starting at the destination index
            length // length of the new array
            );
        return resultArray;
    }
}