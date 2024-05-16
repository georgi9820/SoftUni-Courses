using System;

class Program
{
    static void Main()
    {
        string input1 = Console.ReadLine();
        string[] items = input1.Split(" ");
        int[] array1 = items.Select(int.Parse).ToArray();

        string input2 = Console.ReadLine();
        string[] items2 = input2.Split(" ");
        int[] array2 = items2.Select(int.Parse).ToArray();

        if (AreArraysIdentical(array1, array2))
        {
            Console.WriteLine("Arrays are identical.");
        }
        else
        {
            Console.WriteLine("Arrays are not identical.");
        }
    }

  

    static bool AreArraysIdentical(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }

        return true;
    }
}
