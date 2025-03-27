using Statistics = (int Min, int Max, double Avg);

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Statistics result = Calculate(4, 8, 13);
            Console.WriteLine($"Min = {result.Min} / Max = {result.Max} / Avg = {result.Avg:F2}");


        }
        static Statistics Calculate(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return (0, 0, 0);
            }

            var min = int.MaxValue;
            var max = int.MinValue;
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
                min = (number < min) ? number : min;
                max = (number > max) ? number : max;
            }

            return (min, max, (double)sum/numbers.Length);
        }
    }

   
    
}
