namespace _04.MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesReadInOneHour = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            int totalReadingTime = numberOfPages / pagesReadInOneHour;
            int requiredTimePerDay = totalReadingTime / numberOfDays;

            Console.WriteLine(requiredTimePerDay);
        }
    }
}