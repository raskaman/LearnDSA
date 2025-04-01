// See https://aka.ms/new-console-template for more information

using System.Text;

char[,] map =
{
    { 's', 's', 's', 'g', 'g', 'g','g','g' },
    { 's', 's', 's', 'g', 'g', 'g','g','g' },
    { 's', 's', 's', 's', 's', 'b','b','b' },
    { 's', 's', 's', 's', 's', 'b','s','s' },
    { 'w', 'w', 'w', 'w', 'w', 'b','w','w' },
    { 'w', 'w', 'w', 'w', 'w', 'b','w','w' },
};

Console.OutputEncoding = Encoding.UTF8;

for (int row = 0; row < map.GetLength(0); row++)
{
    for (int col = 0; col < map.GetLength(1); col++)
    {
        Console.ForegroundColor = GetColor(map[row, col]);
        Console.Write(GetChar(map[row, col]) + " ");
    }
    Console.WriteLine();
}
Console.ResetColor();

ConsoleColor GetColor(char terrain)
{
    return terrain switch
    {
        'g' => ConsoleColor.Green,
        's' => ConsoleColor.Yellow,
        'w' => ConsoleColor.Blue,
        _ => ConsoleColor.DarkGray
    };
}

char GetChar(char terrain)
{
    return terrain switch
    {
        'g' => '\u201c',
        's' => '\u25cb',
        'w' => '\u2248',
        _ => '\u25cf'
    };
}