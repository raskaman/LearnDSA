
using System.Diagnostics;

List<AbstractSort> algorithms = [
    new SelectionSort(),
    new InsertionSort(),
    new BubbleSort(),
    new MergeSort(),
    new ShellSort(),
    new QuickSort(),
    new HeapSort()
];

for (int n = 0; n <= 100000; n += 10000)
{
    Console.WriteLine($"\nRunning tests for n = {n}:");
    List<(Type Type, long Ms)> milliseconds = [];
    for (int i = 0; i < 5; i++)
    {
        int[] array = GetRandomArray(n);
        int[] input = new int[n];

        foreach (AbstractSort algorithm in algorithms)
        {
            array.CopyTo(input, 0);

            Stopwatch stopwatch = Stopwatch.StartNew();
            algorithm.Sort(input);
            stopwatch.Stop();

            Type type = algorithm.GetType();
            long ms = stopwatch.ElapsedMilliseconds;
            milliseconds.Add((type, ms));
        }
    }

    List<(Type, double)> results = milliseconds
        .GroupBy(r => r.Type)
        .Select(r =>
            (r.Key, r.Average(t => t.Ms))).ToList();
    foreach ((Type type, double avg) in results)
    {
        Console.WriteLine($"{type.Name}: {avg} ms");
    }
}

int[] GetRandomArray(int length)
{
    Random random = new();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-100000, 100000);
    }
    return array;
}

//int[] arrayOrg = [-11, 12, -42, 0, 90, -9];
////int[] arrayOrg = [-11, 12, -42, 0, 1, 90, 68, 6, -9];
////int[] arrayOrg = [-11, 12, 13, -15, -4, -9, -13];

//int[] array1 = new int[arrayOrg.Length];
//int[] array2 = new int[arrayOrg.Length];
//int[] array3 = new int[arrayOrg.Length];
//int[] array4 = new int[arrayOrg.Length];
//int[] array5 = new int[arrayOrg.Length];
//int[] array6 = new int[arrayOrg.Length];
//int[] array7 = new int[arrayOrg.Length];

//Array.Copy(arrayOrg, array1, arrayOrg.Length);
//Array.Copy(arrayOrg, array2, arrayOrg.Length);
//Array.Copy(arrayOrg, array3, arrayOrg.Length);
//Array.Copy(arrayOrg, array4, arrayOrg.Length);
//Array.Copy(arrayOrg, array5, arrayOrg.Length);
//Array.Copy(arrayOrg, array6, arrayOrg.Length);
//Array.Copy(arrayOrg, array7, arrayOrg.Length);

//Console.WriteLine("Selection Sort");
//SelectionSort.Sort(array1);
//Console.WriteLine($"Original array: {string.Join("| ", arrayOrg)}");
//Console.WriteLine($"Sorted array: {string.Join("| ", array1)}");

//Console.WriteLine("Insertion Sort");
//InsertionSort.Sort(array2);
//Console.WriteLine($"Original array: {string.Join("| ", arrayOrg)}");
//Console.WriteLine($"Sorted array: {string.Join("| ", array2)}");

//Console.WriteLine("Bubble Sort");
//BubbleSort.Sort(array3);
//Console.WriteLine($"Original array: {string.Join("| ", arrayOrg)}");
//Console.WriteLine($"Sorted array: {string.Join("| ", array3)}");

//Console.WriteLine("Merge Sort");
//MergeSort.Sort(array4);
//Console.WriteLine($"Original array: {string.Join("| ", arrayOrg)}");
//Console.WriteLine($"Sorted array: {string.Join("| ", array4)}");

//Console.WriteLine("Shell Sort");
//ShellSort.Sort(array5);
//Console.WriteLine($"Original array: {string.Join("| ", arrayOrg)}");
//Console.WriteLine($"Sorted array: {string.Join("| ", array5)}");

//Console.WriteLine("Quick Sort");
//QuickSort.Sort(array6);
//Console.WriteLine($"Original array: {string.Join("| ", arrayOrg)}");
//Console.WriteLine($"Sorted array: {string.Join("| ", array6)}");

//Console.WriteLine("Heap Sort");
//HeapSort.Sort(array7);
//Console.WriteLine($"Original array: {string.Join("| ", arrayOrg)}");
//Console.WriteLine($"Sorted array: {string.Join("| ", array7)}");
