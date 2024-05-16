using System.Linq;

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] sorted = numbers.OrderByDescending(x => x).Take(3).ToArray();

Console.WriteLine(string.Join(" ", sorted));
