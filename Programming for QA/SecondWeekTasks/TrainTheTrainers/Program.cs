namespace TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryMembers = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            double allGradesSum = 0;
            int counter = 0;

            while (presentationName != "Finish")
            {
                double gradeSum = 0;
                for (int juryMember = 1; juryMember <= juryMembers; juryMember++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());

                    gradeSum += currentGrade;
                    allGradesSum += currentGrade;
                    counter++;
                }

                double averageGrade = gradeSum / juryMembers;
                Console.WriteLine($"{presentationName} - {averageGrade:f2}.");
                presentationName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {allGradesSum / counter:f2}.");
        }
    }
}