char s = char.Parse(Console.ReadLine());
char e = char.Parse(Console.ReadLine());
char x = char.Parse(Console.ReadLine());

int counter = 0;

for (char i = s; i <= e; i++)
{
    for (char j = s; j <= e; j++)
    {
        for (char k = s; k <= e; k++)
        {
            if (i != x && j != x && k != x)
            {
                counter++;
                Console.Write($"{i}{j}{k} ");
            }
        }
    }
}
Console.WriteLine();
Console.Write(counter);
