List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("Contains"))
    {
        int numberContains = int.Parse(command.Split(" ")[1]);
        if (numbers.Contains(numberContains))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command == "PrintEven")
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (command == "PrintOdd")
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (command == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (command.StartsWith("Filter"))
    {
        string condition = command.Split(" ")[1];
        int number = int.Parse(command.Split(" ")[2]);
        switch (condition)
        {
            case "<":
                var filteredNumbersLessThan = numbers.FindAll(x => x < number);
                foreach (var num in filteredNumbersLessThan)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                break;
            case ">":
                var filteredNumbersGreaterThan = numbers.FindAll(x => x > number);
                foreach(var num in filteredNumbersGreaterThan)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                break;
            case "<=":
                var filteredNumbersLessThanOrEqual = numbers.FindAll(x => x <= number);
                foreach (var num in filteredNumbersLessThanOrEqual)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                break;
            case ">=":
                var filteredNumbersGreaterThanOrEqual = numbers.FindAll(x => x >= number);
                foreach (var num in filteredNumbersGreaterThanOrEqual)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                break;
        }
    }
        command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));