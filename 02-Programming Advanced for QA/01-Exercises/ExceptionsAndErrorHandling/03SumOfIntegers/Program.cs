using System.Xml.Linq;

namespace _03SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string[] input = Console.ReadLine().Split(" ");

            foreach (var element in input)
            {
                try
                {
                    int currentElement = int.Parse(element);
                    numbers.Add(currentElement);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{element}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{element}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{element}' processed - current sum: {numbers.Sum()}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {numbers.Sum()}");


        }
    }
}