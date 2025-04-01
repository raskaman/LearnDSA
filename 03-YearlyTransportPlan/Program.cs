using _03_YearlyTransportPlan;
using System.Globalization;

Random random = new();
int meansCount = Enum.GetNames<MeanEnum>().Length;
int year = DateTime.Now.Year;
MeanEnum[][] means = new MeanEnum[12][];

for (int m = 1; m <= 12; m++)
{
    int daysCount = DateTime.DaysInMonth(year, m);
    means[m - 1] = new MeanEnum[daysCount];
    for (int d = 1; d <= daysCount; d++)
    {
        int mean = random.Next(meansCount);
        means[m - 1][d-1] = (MeanEnum)mean;
    }
}

string[] months = GetMonthNames();

int nameLength = months.Max(m => m.Length) + 2;
for (int m = 1; m <= 12; m++)
{
    string month = months[m - 1];
    Console.Write($"{month}:".PadRight(nameLength));
    for (int d = 1; d <= means[m - 1].Length; d++)
    {
        MeanEnum mean = means[m - 1][d - 1];
        (char character, ConsoleColor color) = Get(mean);
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = color;
        Console.Write(character);
        Console.ResetColor();
        Console.Write(" ");
    }
    Console.WriteLine();
}

(char character, ConsoleColor color) Get(MeanEnum mean)
{
    return mean switch
    {
        MeanEnum.Car => ('C', ConsoleColor.Red),
        MeanEnum.Bus => ('B', ConsoleColor.Yellow),
        MeanEnum.Subway => ('S', ConsoleColor.Green),
        MeanEnum.Bike => ('B', ConsoleColor.Blue),
        MeanEnum.Walk => ('W', ConsoleColor.Gray),
        _ => throw new Exception("Invalid mean")
    };
}

string[] GetMonthNames()
{
    CultureInfo culture = new("es");
    string[] names = new string[12];
    foreach (int month in Enumerable.Range(1, 12))
    {
        DateTime firstDay = new(year, month, 1);
        string name = firstDay.ToString("MMMM", culture);
        names[month - 1] = name;
    }
    return names;
}