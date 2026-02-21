namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ivan";
            char[] chars = name.ToCharArray();
            chars[3] = 'r';
            string newName = new string(chars);
            Console.WriteLine(newName);
        }
    }
}
