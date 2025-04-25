public class HeapSort : AbstractSort
{
    public override void Sort(int[] a)
    {
        //Console.WriteLine($"Entry, {string.Join("| ", a)}");
        for (int i = a.Length / 2 - 1; i >= 0; i--) // iterate each node that is not a leaf on the binary heap
        {
            Heapify(a, a.Length, i); // max-heap the binary heap
        }
       // Console.WriteLine($"Heapify, {string.Join("| ", a)}");

        for (int i = a.Length - 1; i > 0; i--)
        {
            (a[0], a[i]) = (a[i], a[0]); // swaps the root element, the max value element with the last element
            //Console.WriteLine($"Swap & remove {string.Join("| ", a)}");
            Heapify(a, i, 0); // builds a max-heap for the binary heap for remaining element, until there is a least one element
            //Console.WriteLine($"Heapify, {string.Join("| ", a)}");
        }
    }

    // Heapify to build a max-heap, places the highest value as the root of the tree
    private static void Heapify(int[] a, int numberOfElements, int indexOfRoot)
    {
        int maxIndex = indexOfRoot; // sets the max index as the root index
        int leftChildIndex = 2 * indexOfRoot + 1; // gets the left element index
        int rightChildIndex = 2 * indexOfRoot + 2; // gets the right element index

        // checks if the left leaf element value is greather than the max element value
        maxIndex = leftChildIndex < numberOfElements &&
            a[leftChildIndex] > a[maxIndex] ? leftChildIndex : maxIndex;

        // checks if the right leaf element value is greather than the max element value
        maxIndex = rightChildIndex < numberOfElements &&
            a[rightChildIndex] > a[maxIndex] ? rightChildIndex : maxIndex;

        if (maxIndex != indexOfRoot) // when the max has changed, is not the root anymore
        {
            (a[indexOfRoot], a[maxIndex]) = (a[maxIndex], a[indexOfRoot]); // swap elements, max element is placed at the root
            Heapify(a, numberOfElements, maxIndex); // build a max-heap from location at which the new max index was found
        }
    }
}
