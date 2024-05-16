using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int pagesNumber = int.Parse(Console.ReadLine());
           int pagesPerHour = int.Parse(Console.ReadLine());
           int days = int.Parse(Console.ReadLine());
        
           int totalTime = pagesNumber / pagesPerHour;
           int hoursPerDay = totalTime / days;
            Console.WriteLine(hoursPerDay);
        }
    }
}
