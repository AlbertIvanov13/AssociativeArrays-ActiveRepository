List<string> words = Console.ReadLine().Split().ToList();

Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

foreach (var word in words)
{
	string lowerCaseWord = word.ToLower();
	if (keyValuePairs.ContainsKey(lowerCaseWord))
	{
		keyValuePairs[lowerCaseWord]++;
	}
	else
	{
		keyValuePairs.Add(lowerCaseWord, 1);
	}
}

foreach (var element in keyValuePairs)
{
	if (element.Value % 2 != 0)
	{
        Console.Write(element.Key + " ");
	}
}