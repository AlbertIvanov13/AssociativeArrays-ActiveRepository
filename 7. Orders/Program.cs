using System.Security.AccessControl;

namespace _7._Orders
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
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