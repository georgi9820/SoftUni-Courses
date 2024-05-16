namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allowedPoorGrades = int.Parse(Console.ReadLine());
      
            int counterPoorGrades = 0;
            int counterProblemSolved = 0;
            int sumOfGrades = 0;
            string lastProblem = "";
            bool isFailed = true;


            while (counterPoorGrades < allowedPoorGrades)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    counterPoorGrades++;
                }
                sumOfGrades += grade;
                counterProblemSolved++;
                lastProblem = problemName;
            }

            double averageScore = (double)sumOfGrades / counterProblemSolved;
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {counterPoorGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {counterProblemSolved}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}