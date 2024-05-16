using System.Xml.Linq;

string input = Console.ReadLine();
int rotations = int.Parse(Console.ReadLine());

string[] values = input.Split(" ");
int[] arr = new int[values.Length];
for (int i = 0; i < values.Length; i++)
{
    arr[i] = int.Parse(values[i]);
}
Rotate(arr, rotations);
static void Rotate(int[] array1, int rotations)
{
    for (int i = 1; i <= rotations; i++)
    {
        int firstElement = array1[0];
        for (int j = 0; j < array1.Length - 1; j++)
        {
            array1[j] = array1[j + 1];
        }

        array1[array1.Length - 1] = firstElement;
    }

    Console.WriteLine(string.Join(" ", array1));
}
