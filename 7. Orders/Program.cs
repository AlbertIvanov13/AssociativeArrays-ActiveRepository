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
				if (name == "buy")
				{
					break;
				}
				double price = double.Parse(commands[1]);
				int quantity = int.Parse(commands[2]);

				if (products.ContainsKey(name))
				{
					products[name].Price = price;
					products[name].Quantity += quantity;
				}
				else
				{
					var product = new Product(name, price, quantity);
					products.Add(name, product);
				}
			}

			foreach (Product product in products.Values)
			{
                Console.WriteLine(product);
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
				return $"{Name} -> {Quantity * Price:f2}";
			}
		}
	}
}