namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            int counterOne = 0;
            int counterTwo = 0;
            int counterThree = 0;
            int counterFour = 0;
            int sumOfGrades = 0;
            double totalGrades = 0;

            for (int i = 1; i <= numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 2.00 && grade <= 2.99)
                {
                    totalGrades += grade;
                    counterOne++;
                }
                else if (grade <= 3.99)
                {
                    totalGrades += grade;
                    counterTwo++;
                }
                else if(grade <= 4.99)
                {
                    totalGrades += grade;
                    counterThree++;
                }
                else
                {
                    totalGrades += grade;
                    counterFour++;
                }
            }

            double averageGrade = totalGrades / numberOfStudents;

            Console.WriteLine($"Top students: {counterFour * 100.00 / numberOfStudents:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {counterThree * 100.00 / numberOfStudents:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {counterTwo * 100.00 / numberOfStudents:F2}%");
            Console.WriteLine($"Fail: {counterOne * 100.00 / numberOfStudents:F2}%");
            Console.WriteLine($"Average: {averageGrade:F2}");
        }
    }
}