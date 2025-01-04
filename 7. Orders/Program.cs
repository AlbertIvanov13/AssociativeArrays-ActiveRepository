namespace _7._Orders
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, double> dictionary = new Dictionary<string, double>();

			while (true)
			{
				string[] input = Console.ReadLine().Split().ToArray();
				string name = input[0];
				if (name == "buy")
				{
					break;
				}
				double price = double.Parse(input[1]);
				int quantity = int.Parse(input[2]);


				if (dictionary.ContainsKey(name))
				{
					dictionary[name] = price;
					foreach (var item in dictionary)
					{
						if (item.Key == name)
						{
							dictionary[name] += quantity;
							break;
						}
					}
					dictionary[name] = price * quantity;
				}

				if (!dictionary.ContainsKey(name))
				{
					dictionary.Add(name, price);
					dictionary[name] += quantity;
					dictionary[name] = price * quantity;
				}
			}

			foreach (var item in dictionary)
			{
				Console.WriteLine($"{item.Key} -> {item.Value:f2}");
			}
		}

		public class Product
		{
            public string Name { get; set; }

            public double Price { get; set; }

            public int Quantity { get; set; }

			public override string ToString()
			{
				return $"{Name} -> {Quantity}";
			}
		}
	}
}