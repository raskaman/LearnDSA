
namespace _03_SortingAlgorithms
{
   public static class SelectionSort
    {
        public static void Sort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int minIndex = i;
                int minValue = a[i];
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < minValue)
                    {
                        minIndex = j;
                        minValue = a[j];
                    }

                }
                if (minIndex == i)
                {
                    continue;
                }
                Console.WriteLine(string.Join("| ", a));
                (a[i], a[minIndex]) = (a[minIndex], a[i]);
            }
        }

        
    }
}
