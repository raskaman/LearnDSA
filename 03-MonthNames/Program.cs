using System.Globalization;

// MONTH NAMES
// Chapter 3 (Arrays and Sorting)
// C# Data Structures and Algorithms, Second Edition

CultureInfo culture = new("es");
string[] months = new string[12];
for (int month = 1; month <= 12; month++)
{
    DateTime firstDay = new(DateTime.Now.Year, month, 1);
    string name = firstDay.ToString("MMMM", culture);
    months[month - 1] = name;
}

foreach (string m in months)
{
    Console.WriteLine(m);
}

