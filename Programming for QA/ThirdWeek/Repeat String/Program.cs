string text = Console.ReadLine();
int repeatCounter = int.Parse(Console.ReadLine());

Console.WriteLine(RepeatedText(text, repeatCounter));

static string RepeatedText(string text, int repeatCounter)
{
    string repeatedText = "";
    for (int i = 0; i < repeatCounter; i++)
    {
        repeatedText += text;
    }
    return repeatedText;
}
