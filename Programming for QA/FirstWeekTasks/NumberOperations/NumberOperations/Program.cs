int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
string op = Console.ReadLine();

int result = 0;

switch (op)
{
    case "+":
        result = num1 + num2;
        
        Console.WriteLine($"{num1} + {num2} = {result:F2}");
        break;
    case "-":
        result = num1 - num2;
        
        Console.WriteLine($"{num1} - {num2} = {result:F2}");
        break;
    case "*":
        result = num1 * num2;
       
        Console.WriteLine($"{num1} * {num2} = {result:f2}");
        break;
    case "/":
        result = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {result:F2}");
        break;
}