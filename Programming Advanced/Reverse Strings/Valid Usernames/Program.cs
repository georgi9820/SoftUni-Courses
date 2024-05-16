using System.Text.RegularExpressions;

string[] names = Console.ReadLine().Split(", ");

string pattern = @"^[a-zA-Z0-9-_]{3,16}$";
Regex regex = new Regex(pattern);

foreach (string name in names)
{
    if (regex.IsMatch(name))
    {
        Console.WriteLine(name);
    }
}
