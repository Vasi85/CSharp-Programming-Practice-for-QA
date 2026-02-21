namespace _01SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            try
            {                
                if(n < 0)
                {
                    throw new Exception("Invalid number.");
                }

                double result = Math.Sqrt(n);
                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}