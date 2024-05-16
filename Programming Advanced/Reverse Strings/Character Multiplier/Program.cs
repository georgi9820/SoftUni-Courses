using System.Diagnostics.CodeAnalysis;
using System.Text;

string[] input = Console.ReadLine().Split();
string str1 = input[0];
string str2 = input[1];

int result = CharacterMultiplier(str1, str2);
Console.WriteLine(result);

static int CharacterMultiplier(string str1, string str2)
{
    int sum = 0;
    int minLength = Math.Min(str1.Length, str2.Length);

    for (int i = 0; i < minLength; i++)
    {
        sum += str1[i] * str2[i];
    }

    for (int i = minLength; i < str1.Length; i++)
    {
        sum += str1[i];
    }

    for (int i = minLength; i < str2.Length; i++)
    {
        sum += str2[i];
    }

    return sum;
}