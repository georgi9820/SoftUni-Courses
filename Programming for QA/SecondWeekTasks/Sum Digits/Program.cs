int number = int.Parse(Console.ReadLine());

int sum = 0;

while (number > 0)
{
    // Extract the last digit of the number
    int digit = number % 10;

    // Add the digit to the sum
    sum += digit;

    // Remove the last digit from the number
    number /= 10;
}
Console.WriteLine(sum);
