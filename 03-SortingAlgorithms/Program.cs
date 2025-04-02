using _03_SortingAlgorithms;

//int[] arrayOrg = [-11, 12, -42, 0, 1, 90, 68, 6, -9];
int[] arrayOrg = [-11, 12, 13, -15, -4, -9, -13];

int[] array1 = new int[arrayOrg.Length];
int[] array2 = new int[arrayOrg.Length];
int[] array3 = new int[arrayOrg.Length];
int[] array4 = new int[arrayOrg.Length];
int[] array5 = new int[arrayOrg.Length];

Array.Copy(arrayOrg, array1, arrayOrg.Length);
Array.Copy(arrayOrg, array2, arrayOrg.Length);
Array.Copy(arrayOrg, array3, arrayOrg.Length);
Array.Copy(arrayOrg, array4, arrayOrg.Length);
Array.Copy(arrayOrg, array5, arrayOrg.Length);

//Console.WriteLine("Selection Sort");
//SelectionSort.Sort(array1);
//Console.WriteLine($"Original array:, {string.Join("| ", arrayOrg)}");

//Console.WriteLine("Insertion Sort");
//InsertionSort.Sort(array2);
//Console.WriteLine($"Original array:, {string.Join("| ", arrayOrg)}");

//Console.WriteLine("Bubble Sort");
//BubbleSort.Sort(array3);
//Console.WriteLine($"Original array:, {string.Join("| ", arrayOrg)}");

//Console.WriteLine("Merge Sort");
//MergeSort.Sort(array4);
//Console.WriteLine($"Original array:, {string.Join("| ", arrayOrg)}");

Console.WriteLine("Shell Sort");
Console.WriteLine($"Original array:, {string.Join("| ", arrayOrg)}");
ShellSort.Sort(array5);
Console.WriteLine($"Original array:, {string.Join("| ", arrayOrg)}");