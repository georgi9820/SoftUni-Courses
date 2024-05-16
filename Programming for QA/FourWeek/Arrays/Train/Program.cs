int length = int.Parse(Console.ReadLine());

int[] arr = new int[length];

int sum = 0;

for (int i = 0; i < length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    sum += arr[i];
}

foreach (int item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine(sum);
