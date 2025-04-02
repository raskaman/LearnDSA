namespace _03_SortingAlgorithms
{
    public static class MergeSort
    {
        public static void Sort(int[] a)
        {
            if (a.Length <= 1) { return; }

            int middle = a.Length / 2;

            // Divide
            int[] left = GetSubarray(a, 0, middle - 1);
            int[] right = GetSubarray(a, middle, a.Length - 1);
            
            Console.WriteLine($" left, {string.Join("| ", left)}");
            Console.WriteLine($"right, {string.Join("| ", right)}");

            Sort(left);
            Sort(right);

            // Conquer
            Merge(a, left, right);
            Console.WriteLine($" left, {string.Join("| ", left)}");
            Console.WriteLine($"right, {string.Join("| ", right)}");
            Console.WriteLine($"merge left and right into a , {string.Join("| ", a)}");
        }

        private static void Merge(int[] a, int[] left, int[] right)
        {
            int leftIndex = 0, rightIndex = 0, orgIndex = 0;
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] <= right[rightIndex]) // Compare the first elements of both arrays
                { 
                    a[orgIndex] = left[leftIndex++]; // Replace the left element from the original array
                    Console.WriteLine($"merge left element {a[orgIndex]} into a");
                }
                else { 
                    a[orgIndex] = right[rightIndex++]; // Replace the right element from the original array
                    Console.WriteLine($"merge right element {a[orgIndex]} into a");
                }
                orgIndex++; // Increment the 
            }
            

            while (leftIndex < left.Length) // While left-over item in the left array
            { 
                a[orgIndex++] = left[leftIndex++]; // Replace the element from the original array

                Console.WriteLine($"merge left left-over element {a[orgIndex -1]} into a");
            }

            while (rightIndex < right.Length) // While left-over item in the right array
            { 
                a[orgIndex++] = right[rightIndex++]; // Replace the element from the original array

                Console.WriteLine($"merge right left-over element {a[orgIndex -1]} into a");
            }

            

        }

        private static int[] GetSubarray(int[] a, int startItem, int endItem)
        {
            int[] result = new int[endItem - startItem + 1];
            Array.Copy(a, startItem, result, 0, endItem - startItem + 1);
            return result;
        }
    }
}
