namespace _02Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Students> students = new List<Students>(); 

            while (input != "end")
            {
                string[] studentInfo = input.Split(" ");
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string homeTown = studentInfo[3];

                Students currentStudent = new Students(firstName, lastName, age, homeTown);

                students.Add(currentStudent);

                input = Console.ReadLine();

            }
            string town = Console.ReadLine();

            foreach (Students student in students.Where(student => student.HomeTown == town))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");

            }
        }
    }
    public class Students
    {
        public Students(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; }

        public string HomeTown { get; set; }
    }
}