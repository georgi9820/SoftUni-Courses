namespace OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            int arTotalMin = arrivalHour * 60 + arrivalMin;
            int exTotalMin = examHour * 60 + examMin;

            int diff = exTotalMin - arTotalMin;

            String status = "";
            String comparison = "";

            if (diff >= 0 && diff <= 30)
            {
                status = "On time";
                comparison = "before";
            }
            else if (diff < 0)
            {
                status = "Late";
                comparison = "after";
                diff = -diff;
            }
            else
            {
                status = "Early";
                comparison = "before";
            }

            int comH = diff / 60;
            int comMin = diff % 60;
            Console.WriteLine(status);
            if (comH > 0)
                Console.WriteLine($"{comH}:{comMin:D2} hours {comparison} the start");
            else if (comMin > 0)
                Console.WriteLine($"{comMin} minutes {comparison} the start");
        }
    }
}