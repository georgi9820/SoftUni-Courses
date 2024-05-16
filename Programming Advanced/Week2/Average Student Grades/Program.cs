int n = int.Parse(Console.ReadLine());

var students = new Dictionary<string, List<decimal>>();

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] inputArr = input.Split();
    string student = inputArr[0];
    decimal grade = decimal.Parse(inputArr[1]);

    if (!students.ContainsKey(student))
    {
        students.Add(student, new List<decimal>());

    }
    students[student].Add(grade);  
}

foreach (var currentStudent in students)
{
    Console.Write($"{currentStudent.Key} -> ");

    foreach (decimal grade in currentStudent.Value)
    {
        Console.Write($"{grade:F2} ");
    }

    Console.WriteLine($"(avg: {currentStudent.Value.Average():F2})");
}

