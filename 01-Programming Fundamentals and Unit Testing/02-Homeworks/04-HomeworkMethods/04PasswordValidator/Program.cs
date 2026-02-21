namespace _04PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            
            CheckPassword(password);

            static void CheckPassword(string password)
            {
                bool IsCorrect = true;

                if (password.Length < 6 || password.Length > 10)
                {
                    Console.WriteLine($"Password must be between 6 and 10 characters");
                    IsCorrect = false;
                }
                if (!password.All(char.IsLetterOrDigit))
                {
                    Console.WriteLine($"Password must consist only of letters and digits");
                    IsCorrect = false;
                }
                int count = password.Count(char.IsDigit);
                if (count < 2)
                {
                    Console.WriteLine($"Password must have at least 2 digits");
                    IsCorrect = false;
                }
                if (IsCorrect)
                {
                    Console.WriteLine($"Password is valid");
                }
            }
        }
    }
}