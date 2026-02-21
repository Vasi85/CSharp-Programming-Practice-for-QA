namespace _05BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                        .Split(" ")
                                        .Select(int.Parse)
                                        .ToList();
            List<int> specialBombNum = Console.ReadLine()
                                              .Split(" ")
                                              .Select(int.Parse)
                                              .ToList();

            int bombNum = specialBombNum[0];
            int bombPower = specialBombNum[1];

            while (numbers.Contains(bombNum))
            {
                int bombNumIndex = numbers.IndexOf(bombNum);

                int leftSide = bombNumIndex - bombPower;
                if (leftSide < 0)
                {
                    leftSide = 0;
                }

                int rightSide = bombNumIndex + bombPower;
                if (rightSide >= numbers.Count)
                {
                    rightSide = numbers.Count - 1;
                }

                numbers.RemoveRange(leftSide, rightSide - leftSide + 1);

            }
            Console.WriteLine(numbers.Sum());
        }
    }
}