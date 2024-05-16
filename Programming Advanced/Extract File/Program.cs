using System.Text.RegularExpressions;

string fileName = Console.ReadLine();

string pattern = @"([^\\]+)\.(\w+)$";
Regex regex = new Regex(pattern);

Match match = regex.Match(fileName);

if (match.Success)
{
    Console.WriteLine("File name: {0}", match.Groups[1].Value);
    Console.WriteLine("File extension: {0}", match.Groups[2].Value);
}

