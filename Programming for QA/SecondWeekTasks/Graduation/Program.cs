namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double totalGrade = 0;
            int classNumber = 1;
            int excluded = 0;

            while (classNumber <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    excluded++;
                }

                if (excluded > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {classNumber - 1} grade");
                    break;
                }

                totalGrade += grade;
                classNumber++;
            }

            if (classNumber == 13) 
            {
                double avaregaeGrade = totalGrade / 12;

                Console.WriteLine($"{name} graduated. Average grade: {avaregaeGrade:F2}");
            }
            
        }
    }
}