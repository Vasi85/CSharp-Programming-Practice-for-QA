namespace _01Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Students> students = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(" ");
                string firstName = studentInfo[0];
                string secondName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);

                Students student = new Students(firstName, secondName, grade);

                students.Add(student);
            }
            foreach (Students student in students.OrderByDescending(student => student.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:F2}");
            }
        }
    }
    class Students
    {
        public Students(string firstName, string secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public double Grade { get; set; }
    }
}