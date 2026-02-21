using System.Collections.Generic;

namespace _04ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                                          .Split(" ")
                                          .Select(int.Parse)
                                          .ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandNum = command.Split(" ");
                string commandAction = commandNum[0];

                if (commandAction == "Add")
                {
                    int numberToAdd = int.Parse(commandNum[1]);
                    numberList.Add(numberToAdd);
                }
                else if (commandAction == "Insert")
                {
                    int number = int.Parse(commandNum[1]);
                    int index = int.Parse(commandNum[2]);

                    numberList.Insert(index, number);
                }
                else if (commandAction == "Remove")
                {
                    int number = int.Parse(commandNum[1]);
                    numberList.Remove(number);
                }
                else if (commandAction == "RemoveAt")
                {
                    int index = int.Parse(commandNum[1]);
                    numberList.RemoveAt(index);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}