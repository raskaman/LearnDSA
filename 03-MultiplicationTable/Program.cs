// See https://aka.ms/new-console-template for more information
int[,] results = new int[10, 10];

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        results[i, j] = (i + 1) * (j + 1);
        Console.Write($"{results[i, j],4}");
    }
    Console.WriteLine();
}
