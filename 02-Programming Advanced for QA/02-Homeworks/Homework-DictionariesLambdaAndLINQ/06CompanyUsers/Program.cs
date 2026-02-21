namespace _06CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> companyInfo = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] inputInfo = input.Split(" -> ");

                string companyName = inputInfo[0];
                string employeeId = inputInfo[1];

                if (companyInfo.ContainsKey(companyName))
                {
                    if (!companyInfo[companyName].Contains(employeeId))
                    {
                        companyInfo[companyName].Add(employeeId);
                    }

                }
                else
                {
                    companyInfo.Add(companyName, new List<string>());
                    companyInfo[companyName].Add(employeeId);
                }

                input = Console.ReadLine();
            }

            foreach (var item in companyInfo)
            {
                Console.WriteLine(item.Key);

                foreach (var employeeId in item.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}