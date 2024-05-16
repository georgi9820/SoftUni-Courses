using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string password = Console.ReadLine();

        string validationMessage = ValidatePassword(password);
        if (validationMessage == "Valid")
        {
            Console.WriteLine("Password is valid");
        }
        else
        {
            Console.WriteLine(validationMessage);
        }
    }

    static string ValidatePassword(string password)
    {
        string errorMessage = "";

        if (password.Length < 6 || password.Length > 10)
        {
            errorMessage += "Password must be between 6 and 10 characters\n";
        }

        if (!password.All(char.IsLetterOrDigit))
        {
            errorMessage += "Password must consist only of letters and digits\n";
        }

        int digitCount = password.Count(char.IsDigit);
        if (digitCount < 2)
        {
            errorMessage += "Password must have at least 2 digits\n";
        }

        return errorMessage == "" ? "Valid" : errorMessage;
    }
}


