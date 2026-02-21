namespace _03Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, double[]> products = new Dictionary<string, double[]>();
            
            while (input != "buy")
            {
                string[] productInfo = input.Split(' ');

                string productName = productInfo[0];
                double productPrice = double.Parse(productInfo[1]);
                double productQuantity = double.Parse(productInfo[2]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new double[2]);
                }

                products[productName][0] = productPrice;
                products[productName][1] += productQuantity;

                input = Console.ReadLine();
            }

            foreach (var item in products)
            {
                double productPrise = item.Value[0];
                double productQuantity = item.Value[1];

                double totalPrice = productPrise * productQuantity;

                Console.WriteLine($"{item.Key} -> {totalPrice:F2}");
            }
        }
    }
}