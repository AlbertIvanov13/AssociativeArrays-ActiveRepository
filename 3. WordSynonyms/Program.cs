Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
	string word = Console.ReadLine();
	string synonym = Console.ReadLine();

	if (words.ContainsKey(word))
	{
		words.Add(synonym, new List<string>());
	}
	else
	{
		words.Add(word, new List<string>());
		words.Add(synonym, new List<string>());
	}
}

foreach (var word in words)
{
    Console.Write($"{word.Key} - ");
	foreach (var item in words)
	{
		if (word.Value.Count > 1)
		{
			Console.WriteLine($"{word.Value}");
		}
		else
		{
			Console.Write($"{word.Value.},");
		}
		continue;
	}
}