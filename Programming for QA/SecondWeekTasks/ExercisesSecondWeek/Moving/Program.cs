namespace Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lengthFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());

            int totalVolumeFreeSpace = widthFreeSpace * lengthFreeSpace * heightFreeSpace;

            string input = Console.ReadLine();
            int takenVolume = 0;
            while (input != "Done")
            {
                int numberOfBoxes = int.Parse(input);
                takenVolume += numberOfBoxes;
                if (takenVolume > totalVolumeFreeSpace)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (totalVolumeFreeSpace >= takenVolume)
            {
                Console.WriteLine($"{totalVolumeFreeSpace - takenVolume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {takenVolume - totalVolumeFreeSpace} Cubic meters more.");
            }

        }
    }
}