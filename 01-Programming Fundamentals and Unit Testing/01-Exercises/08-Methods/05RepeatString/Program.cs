namespace _05RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(text, repeatCount));

            static string RepeatString(string text, int repeatCount)
            {
                string repeat = "";

                for (int i = 0; i < repeatCount; i++)
                {
                    repeat += text;
                }
                return repeat;
            }
        
        }
    }
}