using System;

class Program
{
    static void Main()
    {
        string bigNumber = Console.ReadLine().Trim();
        int singleDigit = int.Parse(Console.ReadLine());

        string result = MultiplyBigNumber(bigNumber, singleDigit);

        Console.WriteLine(result);
    }

    static string MultiplyBigNumber(string number, int multiplier)
    {
        if (multiplier == 0)
        {
            return "0";
        }

        int carry = 0;
        string result = string.Empty;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int digit = int.Parse(number[i].ToString());
            int product = (digit * multiplier) + carry;
            carry = product / 10;
            result = (product % 10) + result;
        }

        if (carry > 0)
        {
            result = carry + result;
        }

        return result;
    }
}

