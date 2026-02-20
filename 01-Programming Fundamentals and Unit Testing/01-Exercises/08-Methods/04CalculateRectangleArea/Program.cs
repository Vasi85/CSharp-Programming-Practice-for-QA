namespace _04CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            CalculateRectangleArea(width, height);

            static void CalculateRectangleArea(int width, int height)
            {
                int area = width * height;
                Console.WriteLine(area);
            }
            
        }
    }
}
