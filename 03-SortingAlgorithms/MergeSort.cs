namespace _03_SortingAlgorithms
{
    public static class MergeSort
    {
        public static void Sort(int[] a)
        {
            if (a.Length <= 1) { return; } // when there is only one element or less, not need to sort

            int middle = a.Length / 2;

            // Divide
            int[] left = GetSubarray(a, 0, middle - 1); // left part of the a array
            int[] right = GetSubarray(a, middle, a.Length - 1); // right part of the a array

            Console.WriteLine($" left, {string.Join("| ", left)}");
            Console.WriteLine($"right, {string.Join("| ", right)}");

            Sort(left); // recursive call to sort the left array
            Sort(right); // recursive call to sort the right array

            // Conquer
            Merge(a, left, right);

            Console.WriteLine($" left, {string.Join("| ", left)}");
            Console.WriteLine($"right, {string.Join("| ", right)}");
            Console.WriteLine($"merge left and right into a , {string.Join("| ", a)}");
        }

        // merge the left and right arrays into the a array
        private static void Merge(int[] a, int[] left, int[] right)
        {
            int leftIndex = 0, // keeps track of the left element index
                rightIndex = 0, // keeps track of the right element index
                orgIndex = 0; // keeps track of the original array element index
            while (leftIndex < left.Length && rightIndex < right.Length) // do while both left and right stil have elements to check
            {
                if (left[leftIndex] <= right[rightIndex]) // compare the elements of both arrays at the corresponding index
                { 
                    a[orgIndex] = left[leftIndex++]; // replace original array at orgIndex with left element and increment leftIndex
                    Console.WriteLine($"merge left element {a[orgIndex]} into a");
                }
                else { 
                    a[orgIndex] = right[rightIndex++]; // replace original array at orgIndex with the right element and increment rightIndex
                    Console.WriteLine($"merge right element {a[orgIndex]} into a");
                }
                orgIndex++; // increment the orgIndex by 1
            }

            while (leftIndex < left.Length) // while left-over items in the left array
            { 
                a[orgIndex++] = left[leftIndex++]; // replace the element from the original array

                Console.WriteLine($"merge left left-over element {a[orgIndex -1]} into a");
            }

            while (rightIndex < right.Length) // While left-over items in the right array
            { 
                a[orgIndex++] = right[rightIndex++]; // Replace the element from the original array

                Console.WriteLine($"merge right left-over element {a[orgIndex -1]} into a");
            }
        }

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
}
