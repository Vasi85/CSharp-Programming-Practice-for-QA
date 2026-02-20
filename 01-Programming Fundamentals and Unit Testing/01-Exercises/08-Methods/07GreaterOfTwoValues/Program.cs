namespace _07GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            PrintGreaterValue(type, value1, value2);

            static void PrintGreaterValue(string type, string value1, string value2)
            {

                if (type == "int")
                {
                    int first = int.Parse(value1);
                    int second = int.Parse(value2);

                    int biggest = TwoIntegers(first, second);

                    Console.WriteLine(biggest);
                }
                else if (type == "char")
                {
                    char first = char.Parse(value1);
                    char second = char.Parse(value2);

                    char biggest = TwoChars(first, second);

                    Console.WriteLine(biggest);
                }
                else if (type == "string")
                {
                    string biggest = TwoStrings(value1, value2);
                    Console.WriteLine(biggest);
                }

                static int TwoIntegers(int value1, int value2)
                {
                    if (value1 > value2)
                    {
                        return value1;
                    }
                    return value2;
                }

                static char TwoChars(char value1, char value2)
                {
                    if (value1 > value2)
                    {
                        return value1;
                    }
                    return value2;
                }
                static string TwoStrings(string value1, string value2)
                {
                    int result = value1.CompareTo(value2);

                    if (result > 0)
                    {
                        return value1;
                    }
                    return value2;
                }
            }
        }
    }
}