

string text = Console.ReadLine();

Dictionary<char, int> dictionary = new Dictionary<char, int>();

var withoutSpace = text.Where(t => t != ' ').ToList();

List<char> chars = new List<char>();
int counter = 0;
for (int i = 0; i < withoutSpace.Count; i++)
{
	char symbol = withoutSpace[i];
	chars.Add(symbol);
	if (dictionary.ContainsKey(symbol))
	{
		dictionary.Add(symbol, counter++);
	}
}