using System.Diagnostics;
using System.Xml.Linq;

namespace _05StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsAverageGrade = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsAverageGrade.ContainsKey(studentName))
                {
                    studentsAverageGrade.Add(studentName, new List<double>());
                }
                studentsAverageGrade[studentName].Add(grade);
            }
            foreach (var item in studentsAverageGrade.Where(s => s.Value.Average() >= 4.50))
            {
                string studentName = item.Key;
                double averageGrade = item.Value.Average();

                Console.WriteLine($"{item.Key} -> {averageGrade:F2}");
            }
        }
    }
}