int floorsCount = int.Parse(Console.ReadLine());
int estatesCount = int.Parse(Console.ReadLine());

string type = "";
for (int floor = floorsCount; floor >= 1; floor--)
{
    for (int estates = 0; estates < estatesCount; estates++)
    {
        if (floor == floorsCount)
        {
            Console.Write($"L{floor}{estates} ");
        }
        else if (floor % 2 == 0)
        {
            Console.Write($"O{floor}{estates} ");
        }
        else
        {
            Console.Write($"A{floor}{estates} ");
        }
    }
    Console.WriteLine();
}
