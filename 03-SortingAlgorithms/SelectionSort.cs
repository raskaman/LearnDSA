
namespace _03_SortingAlgorithms
{
   public static class SelectionSort
    {
        public static void Sort(int[] a)
        {
            for (int i = 0; // start at index 0
                i < a.Length - 1; // condition: iterate until one element is left in the unsorted part
                i++ // increment i by one
                ) // iterate for each element in the array minus one
            {
                int minIndex = i; // keeps track of the current i element index from the for loop above
                int minValue = a[i]; // keeps track of the current i element value fromn the for loop above
                for (int j = i + 1; // start iterating the inner for at the next element after i
                    j < a.Length; // condition: iterate until last element in the unsorted part
                    j++ // increment j by one
                    ) // iterate for each element in the array after current i element
                {
                    if (a[j] < minValue) // checks if the value of the array element at j index is smaller than minValue
                    {
                        minIndex = j; // updates the min index to the array element at j index
                        minValue = a[j]; // updates the min value to the value of the array element at j index
                    }
                }

                if (minIndex == i) // if the minIndex has not change, the current i element index is the smallest
                {
                    continue; // move to the next element in the array
                }

                Console.WriteLine(string.Join("| ", a));
                (a[i], a[minIndex]) = (a[minIndex], a[i]); // swap elements, place the smallest in the sorted part
            }
        }

        
    }
}
