
char startChar = char.Parse(Console.ReadLine());
char endChar = char.Parse(Console.ReadLine());
string inputString = Console.ReadLine();

int asciiSum = 0;

for (int i = 0; i < inputString.Length; i++)
{
    char currentChar = inputString[i];

    if (currentChar > startChar && currentChar < endChar)
    {
        asciiSum += (int)currentChar;
    }
}

Console.WriteLine(asciiSum);


