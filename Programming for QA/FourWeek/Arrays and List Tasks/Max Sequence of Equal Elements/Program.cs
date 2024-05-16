using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Read the input sequence from the console
        List<int> sequence = Console.ReadLine()
                                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToList();

        // Initialize variables to keep track of the current sequence and the longest sequence
        List<int> currentSequence = new List<int> { sequence[0] };
        List<int> longestSequence = new List<int> { sequence[0] };

        // Iterate through the sequence to find the longest sequence
        for (int i = 1; i < sequence.Count; i++)
        {
            if (sequence[i] == sequence[i - 1])
            {
                currentSequence.Add(sequence[i]);
            }
            else
            {
                currentSequence = new List<int> { sequence[i] };
            }

            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = new List<int>(currentSequence);
            }
        }

        // Print the leftmost longest sequence
        Console.WriteLine(string.Join(" ", longestSequence));
    }
}
