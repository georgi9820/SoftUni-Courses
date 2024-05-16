using System.Text;

int lines = int.Parse(Console.ReadLine());

for (int line = 1; line <= lines; line++)
{
    string input = Console.ReadLine();

    // Намираме индексите на символите '@' и '|'
    int atIndex = input.IndexOf('@');
    int pipeIndex = input.IndexOf('|');

    // Намираме индексите на символите '#' и '*'
    int hashIndex = input.IndexOf('#');
    int asteriskIndex = input.IndexOf('*');

    // Използваме метода Substring, за да извлечем поднизите
    string name = input.Substring(atIndex + 1, pipeIndex - atIndex - 1);
    string age = input.Substring(hashIndex + 1, asteriskIndex - hashIndex - 1);

    Console.WriteLine($"{name} is {age} years old.");
}





