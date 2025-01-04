
string text = Console.ReadLine();

Dictionary<char, int> dictionary = new Dictionary<char, int>();

var withoutSpace = text.Where(t => t != ' ').ToList();

List<char> letters = new List<char>();
int counter = 0;
for (int i = 0; i < withoutSpace.Count; i++)
{
	char symbol = withoutSpace[i];
	letters.Add(symbol);

	if (!dictionary.ContainsKey(symbol))
	{
		counter = 0;
		counter++;
		dictionary.Add(symbol, counter);
		var letterss = text.Where(t => t == symbol).ToList();
		foreach (var item in letterss)
		{
			Console.WriteLine($"{item} -> {letterss.Count}");
			break;
		}
	}
}