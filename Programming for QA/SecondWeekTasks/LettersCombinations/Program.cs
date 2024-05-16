namespace LettersCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            char skipChar = char.Parse(Console.ReadLine());

            int combinationsCount = 0;

            for (char firstChar = startChar; firstChar <= endChar; firstChar++)
            {
                if (firstChar == skipChar)
                {
                    continue;
                }

                for (char secondChar = startChar; secondChar <= endChar; secondChar++)
                {
                    if (secondChar == skipChar)
                    {
                        continue;
                    }

                    for (char thirdChar = startChar; thirdChar <= endChar; thirdChar++)
                    {
                        if (thirdChar == skipChar)
                        {
                            continue;
                        }

                        Console.Write($"{firstChar}{secondChar}{thirdChar} ");
                        combinationsCount++;
                    }
                }
            }

            Console.WriteLine(combinationsCount);
        }
    }
}