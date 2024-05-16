string values = Console.ReadLine();
int sum = 0;
string[] items = values.Split(" ");
int[] arr = new int[items.Length];

for (int i = 0; i < items.Length; i++)
{
    arr[i] = int.Parse(items[i]);
    sum += arr[i];
}

Console.WriteLine(sum);
