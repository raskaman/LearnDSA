public class InsertionSort : AbstractSort
{
    public override void Sort(int[] a)
    {
        for (int i = 1; i < a.Length; i++) // iterate each element of the array
        {
            int j = i; // keeps track of the latest element in the for loop
            while (j > 0 && a[j] < a[j - 1]) // loop the array and compare elements with the adjancent one
            {
                //Console.WriteLine(string.Join("| ", a));
                (a[j], a[j - 1]) = (a[j - 1], a[j]); // swap elements
                j--; // reduce j by 1
            }
        }
    }
}
