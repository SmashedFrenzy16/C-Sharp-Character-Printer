// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.DarkRed;

int x;

x = 0;

while (x < 256)
{
    Console.WriteLine($"{x}: {(char)x}");

    x++;
}
