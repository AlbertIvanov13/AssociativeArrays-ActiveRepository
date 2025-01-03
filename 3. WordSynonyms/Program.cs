Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
	string word = Console.ReadLine();
	string synonym = Console.ReadLine();

	if (words.ContainsKey(word))
	{
		words[word].Add(synonym);
	}
	else
	{
		words.Add(word, new List<string>());
		words[word].Add(synonym);
	}
}

foreach (var word in words)
{
	Console.Write($"{word.Key} - ");
	for (int i = 0; i < word.Value.Count; i++)
	{
		if (word.Value.Count > 1)
		{
			if (i == word.Value.Count - 1)
			{
				Console.Write($"{word.Value[i]}");
                Console.WriteLine();
			}
			else
			{
				Console.Write($"{word.Value[i]}, ");
			}
		}
		else
		{
			Console.Write($"{word.Value[i]}");
			Console.WriteLine();
		}
	}
}