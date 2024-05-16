//Find All Not Equal Words In 2 Lists
List<string> names = new List<string>() {
"csharp", "java", "coding", "QA", "debugging", "python", "mysql"};
List<string> langs = new List<string>() {
"csharp", "java", "python", "php", "javascript"};

List<string> output = new List<string>();
output = names.Except(langs).ToList();

Console.WriteLine(string.Join(" ", output));

//Find All Not Equal Words In 2 Lists
//List<string> names = new List<string>() { 
//"csharp", "java", "coding", "QA", "debugging", "python", "mysql"};
//List<string> langs = new List<string>() {
//"csharp", "java", "python", "php", "javascript"};

//List<string> output = new List<string>();
//output = names.Except(langs).ToList();

//Console.WriteLine(string.Join(" ", output));

//10. *Top Integers
//List<int> numbers = Console.ReadLine()
//                                   .Split(" ")
//                                   .Select(int.Parse)
//                                   .ToList();

//List<int> output = new List<int>();

//for (int i = 0; i < numbers.Count; i++)
//{
//    bool isTopNumber = true;
//    for (int j = i + 1; j < numbers.Count; j++)
//    {
//        if (numbers[i] <= numbers[j])
//        {
//            isTopNumber = false;
//            break;
//        }
//    }
//    if (isTopNumber)
//    {
//        output.Add(numbers[i]);
//    }
//}

//Console.WriteLine(string.Join(" ", output));

//9. *Max Sequence of Equal Elements
//List<int> sequence = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

//List<int> currentSequence = new List<int>() { sequence[0] };
//List<int> longestSequence = new List<int>() { sequence[0] };

//for (int i = 1; i < sequence.Count; i++)
//{
//    if (sequence[i] == sequence[i - 1])
//    {
//        currentSequence.Add(sequence[i]);
//    }
//    else
//    {
//        currentSequence = new List<int> { sequence[i] };
//    }

//    if (currentSequence.Count > longestSequence.Count)
//    {
//        longestSequence = new List<int>(currentSequence);
//    }
//}

//Console.WriteLine(string.Join(" ", longestSequence));

//5. List Manipulation Advanced - task
//List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

//string command = Console.ReadLine();

//while (command != "end")
//{
//    if (command.StartsWith("Contains"))
//    {
//        int number = int.Parse(command.Split(" ")[1]);
//        if (numbers.Contains(number))
//        {
//            Console.WriteLine("Yes");
//        }
//        else
//        {
//            Console.WriteLine("No such number");
//        }
//    }
//    else if (command.StartsWith("PrintEven"))
//    {
//        foreach (int number in numbers)
//        {
//            if (number % 2 == 0)
//            {
//                Console.Write(number + " ");
//            }
//        }
//    }
//    else if (command.StartsWith("PrintOdd"))
//    {
//        foreach (int number in numbers)
//        {
//            if (number % 2 != 0)
//            {
//                Console.Write(number + " ");
//            }
//        }
//    }
//    else if (command.StartsWith("GetSum"))
//    {
//        int sum = numbers.Sum();
//        Console.WriteLine(sum);
//    }
//    else if (command.StartsWith("Filter"))
//    {
//        string condition = command.Split(" ")[1];
//        int number = int.Parse(command.Split(" ")[2]);
//        switch (condition)
//        {
//            case "<":
//                var filteredNumbersLessThan = numbers.FindAll(x => x < number);
//                foreach (var num in filteredNumbersLessThan)
//                {
//                    Console.Write(num + " ");
//                }
//                Console.WriteLine();
//                break;
//            case ">":
//                var filteredNumbersGreaterThan = numbers.FindAll(x => x > number);
//                foreach (var num in filteredNumbersGreaterThan)
//                {
//                    Console.Write(num + " ");
//                }
//                Console.WriteLine();
//                break;
//            case "<=":
//                var filteredNumbersLessThanOrEqual = numbers.FindAll(x => x <= number);
//                foreach (var num in filteredNumbersLessThanOrEqual)
//                {
//                    Console.Write(num + " ");
//                }
//                Console.WriteLine();
//                break;
//            case ">=":
//                var filteredNumbersGreaterThanOrEqual = numbers.FindAll(x => x >= number);
//                foreach (var num in filteredNumbersGreaterThanOrEqual)
//                {
//                    Console.Write(num + " ");
//                }
//                Console.WriteLine();
//                break;
//        }

//    }
//    command = Console.ReadLine();
//}

//Console.WriteLine(string.Join(" ", numbers));

//4. List Manipulation Basics 
//List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

//string command = Console.ReadLine();

//while (command != "end")
//{
//    if (command.StartsWith("Add"))
//    {
//        int number = int.Parse(command.Split(" ")[1]);
//        numbers.Add(number);
//    }
//    else if (command.StartsWith("RemoveAt"))
//    {
//        int index = int.Parse(command.Split(" ")[1]);
//        numbers.RemoveAt(index);
//    }
//    else if (command.StartsWith("Remove"))
//    {
//        int number = int.Parse(command.Split(" ")[1]);
//        numbers.Remove(number);
//    }
//    else if (command.StartsWith("Insert"))
//    {
//        int number = int.Parse(command.Split(" ")[1]);
//        int index = int.Parse(command.Split(" ")[2]);
//        numbers.Insert(index, number);
//    }
//    command = Console.ReadLine();
//}

//Console.WriteLine(string.Join(" ", numbers));

//3. Remove Negatives and Reverse - task
//List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

//numbers.RemoveAll(x => x < 0);
//numbers.Reverse();

//if (numbers.Count < 1)
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine(string.Join(" ", numbers));
//}


//2.List of Products - task
//int n = int.Parse(Console.ReadLine());

//List<string> products = new List<string>();

//for (int i = 1; i <= n; i++)
//{
//    string product = Console.ReadLine();
//    products.Add(product);
//}

//products.Sort();

//int counter = 1;
//foreach (string product in products)
//{
//    Console.WriteLine(counter + "." + product);
//    counter++;
//}



//1.Change List - task
//List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

//string command = Console.ReadLine();

//while (command != "end")
//{
//    string[] commandParts = command.Split(" ");
//    string commandName = commandParts[0];
//    int element = int.Parse(commandParts[1]);
//    if (commandName == "Delete")
//    {
//        numbers.RemoveAll(number => number == element);
//    }
//    else if(commandName == "Insert")
//    {
//        int position = int.Parse(commandParts[2]);
//        numbers.Insert(position, element);
//    }

//    command = Console.ReadLine();
//}

//Console.WriteLine(string.Join(" ", numbers));
