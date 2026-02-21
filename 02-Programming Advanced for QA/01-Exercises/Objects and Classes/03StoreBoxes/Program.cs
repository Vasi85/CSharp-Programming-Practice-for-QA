using System.Text;

namespace _03StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while(input != "end")
            {
                string[] boxInfo = input.Split(' ');
                string serialNumber = boxInfo[0];
                string itemName = boxInfo[1];
                int itemQuantity = int.Parse(boxInfo[2]);
                double itemPrice = double.Parse(boxInfo[3]);

                Item currentItem = new Item(itemName, itemPrice);
                Box currentBox = new Box(serialNumber, currentItem, itemQuantity);

                boxes.Add(currentBox);

                input = Console.ReadLine();
            }
            foreach (Box box in boxes.OrderByDescending(box => box.Price))
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(box.SerialNumber);
                sb.AppendLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                sb.AppendLine($"-- ${box.Price:F2}");

                Console.WriteLine(sb.ToString().TrimEnd());
            }
        }
    }
    public class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }
    }
    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity )
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public double Price => ItemQuantity * Item.Price;
    }
}