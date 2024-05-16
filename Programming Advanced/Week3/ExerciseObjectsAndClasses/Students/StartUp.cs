namespace Students
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> studentList = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputArr = input.Split(" ").ToArray();
                string firstName = inputArr[0];
                string lastName = inputArr[1];
                double grade = double.Parse(inputArr[2]);
                Student student = new Student(firstName, lastName, grade);
                studentList.Add(student);
            }

            var orderedStudents = studentList.OrderByDescending(student => student.Grade).ToList();

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }

        }
    }
}
