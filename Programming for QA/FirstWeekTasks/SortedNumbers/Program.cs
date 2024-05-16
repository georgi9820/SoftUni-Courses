int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

if (first <= second && second <= third && third > first)
{
    Console.WriteLine("Ascending");
}
else if (first >= second && second >= third && first > third)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}
