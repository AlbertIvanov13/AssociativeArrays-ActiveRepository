using System.Security.AccessControl;

namespace _7._Orders
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Product> products = new Dictionary<string, Product>();

			while (true)
			{
				string[] commands = Console.ReadLine().Split();
				string name = commands[0];
				double price = double.Parse(commands[1]);
				int quantity = int.Parse(commands[2]);

				if (name == "buy")
				{
					break;
				}

				if (products.ContainsKey(name))
				{

				}
			}

			foreach (string name in products.Keys)
			{

			}
		}

		public class Product
		{
            public string Name { get; set; }

            public double Price { get; set; }

            public int Quantity { get; set; }

            public Product(string name, double price, int quantity)
            {
                Name = name;
				Price = price;
				Quantity = quantity;
            }

            public override string ToString()
			{
				return $"{Name} -> {Quantity * Price}";
			}
		}
	}
}