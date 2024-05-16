using System.Xml.Linq;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string assessorName;
            double assessorPoints;
            int lenghtName;
            for (int assessor = 1; assessor <= n; assessor++)
            {
                assessorName = Console.ReadLine();
                assessorPoints = double.Parse(Console.ReadLine());
                lenghtName = assessorName.Length;
                pointsFromAcademy += lenghtName * assessorPoints / 2;
                if (pointsFromAcademy >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {pointsFromAcademy:F1}!");
                    break;
                }

            }

            if (pointsFromAcademy < 1250.5)
            {
                Console.WriteLine($"Sorry, {nameOfActor} you need {1250.5 - pointsFromAcademy:F1} more!");
            }
        }
    }
}