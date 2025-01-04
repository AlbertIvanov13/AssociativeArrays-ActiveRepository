
string text = Console.ReadLine();

Dictionary<char, int> dictionary = new Dictionary<char, int>();

var withoutSpace = text.Where(t => t != ' ').ToList();

int counter = 0;
for (int i = 0; i < withoutSpace.Count; i++)
{
	char symbol = withoutSpace[i];
	if (!dictionary.ContainsKey(symbol))
	{
		if (counter == 0)
		{
			counter++;
			dictionary.Add(symbol, counter);
		}
	}
}

foreach (var symbol in dictionary)
{
    Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
}