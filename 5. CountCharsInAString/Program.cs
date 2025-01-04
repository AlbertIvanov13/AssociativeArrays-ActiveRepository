
string text = Console.ReadLine();

Dictionary<char, int> dictionary = new Dictionary<char, int>();

var withoutSpace = text.Where(t => t != ' ').ToList();

List<char> letters = new List<char>();
for (int i = 0; i < withoutSpace.Count; i++)
{
	char symbol = withoutSpace[i];
	letters.Add(symbol);

	if (!dictionary.ContainsKey(symbol))
	{
		var letterss = text.Where(t => t == symbol).ToList();
		dictionary.Add(symbol, letterss.Count);
	}
}

foreach (var item in dictionary)
{
	Console.WriteLine($"{item.Key} -> {item.Value}");
}