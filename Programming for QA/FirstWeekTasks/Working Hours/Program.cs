﻿int hour = int.Parse(Console.ReadLine());
string dayOfTheWeek = Console.ReadLine();

if (hour >= 10 && hour <= 18 && (dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday" || dayOfTheWeek == "Saturday"))
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}
