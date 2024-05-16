using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Dictionary<string, char> morseToLetter = new Dictionary<string, char>()
        {
            {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'},
            {".", 'E'}, {"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'},
            {"..", 'I'}, {".---", 'J'}, {"-.-", 'K'}, {".-..", 'L'},
            {"--", 'M'}, {"-.", 'N'}, {"---", 'O'}, {".--.", 'P'},
            {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'},
            {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'},
            {"-.--", 'Y'}, {"--..", 'Z'},
        };

        string input = Console.ReadLine();
        string[] morseWords = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string morseWord in morseWords)
        {
            string[] morseLetters = morseWord.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string morseLetter in morseLetters)
            {
                if (morseToLetter.ContainsKey(morseLetter))
                {
                    Console.Write(morseToLetter[morseLetter]);
                }
                else
                {
                    // Handle space between words
                    Console.Write(' ');
                }
            }
            Console.Write(' '); // Add space between words
        }

        Console.WriteLine();
    }
}

