namespace _02Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            PrintGradesWord(num);


            static void PrintGradesWord(double num)
            {
                string gradeWord = "";

                switch (num)
                {
                    case >= 2.00 and <= 2.99:
                        gradeWord = "Fail";
                        break;
                    case >= 3.00 and <= 3.49:
                        gradeWord = "Average";
                        break;
                    case >= 3.50 and <= 4.49:
                        gradeWord = "Good";
                        break;
                    case >= 4.50 and <= 5.49:
                        gradeWord = "Very good";
                        break;
                    case >= 5.50 and <= 6.00:
                        gradeWord = "Excellent";
                        break;
                }
                Console.WriteLine(gradeWord);
            }
        

        }
    }
}