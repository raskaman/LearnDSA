using Statistics = (int Min, int Max, double Avg);

Console.WriteLine("Hello, World!");

Statistics result = Calculate(4, 8, 13);
Console.WriteLine($"Min = {result.Min} / Max = {result.Max} / Avg = {result.Avg:F2}");
Price regularPrice = new Price(100, CurrencyEnum.USD);
Console.WriteLine(regularPrice);
Price discountedPrice = regularPrice with { Amount = 80 };
Console.WriteLine(discountedPrice);


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

    return (min, max, (double)sum / numbers.Length);
}

public readonly struct Price(decimal Amount, CurrencyEnum Currency)
{
    public readonly decimal Amount { get; init; } = Amount;
    public readonly CurrencyEnum Currency { get; init; } = Currency;

    public override string ToString() => $"{Amount} {Currency}";
}

public enum CurrencyEnum
{
    USD,
    EUR,
    GBP
}