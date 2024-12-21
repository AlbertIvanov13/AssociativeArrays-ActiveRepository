namespace _01._CountRealNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

			SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();

			for (int i = 0; i < numbers.Count; i++)
			{
				if (!dictionary.ContainsKey(numbers[i]))
				{
					dictionary.Add(numbers[i], 0);
				}

				dictionary[numbers[i]]++;
			}

			foreach (var number in dictionary)
			{
				Console.WriteLine($"{number.Key} -> {number.Value}");
			}
		}
	}
}