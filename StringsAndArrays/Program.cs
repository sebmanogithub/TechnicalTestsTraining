
bool hasAllUniqueCharacters = HasStringAllUniqueCharacters("abcdefg");
Console.WriteLine("hasAllUniqueCharacters " + hasAllUniqueCharacters);

bool hasAllUniqueCharacters2 = HasStringAllUniqueCharacters("abcdefag");
Console.WriteLine("hasAllUniqueCharacters " + hasAllUniqueCharacters2);

bool hasAllUniqueCharacters3 = HasStringAllUniqueCharactersBis("abcdefg");
Console.WriteLine("hasAllUniqueCharacters " + hasAllUniqueCharacters);

bool hasAllUniqueCharacters4 = HasStringAllUniqueCharactersBis("abcdefag");
Console.WriteLine("hasAllUniqueCharacters " + hasAllUniqueCharacters2);

bool hasAllUniqueCharacters5 = HasStringAllUniqueCharactersLinq("abcdefg");
Console.WriteLine("hasAllUniqueCharacters " + hasAllUniqueCharacters);

bool hasAllUniqueCharacters6 = HasStringAllUniqueCharactersLinq("abcdefag");
Console.WriteLine("hasAllUniqueCharacters " + hasAllUniqueCharacters2);


static bool HasStringAllUniqueCharacters(string str)
{
    HashSet<char> result = new HashSet<char>();
    foreach (char c in str)
    {
        if (!result.Add(c))
        {
            return false;
        }
    }
    return true;
}


static bool HasStringAllUniqueCharactersBis(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = i+1; j < str.Length; j++)
        {
            if (str[i] == str[j])
            {
                return false;
            }
        }
    }
    return true;
}

static bool HasStringAllUniqueCharactersLinq(string str)
{
    return str.Distinct().Count() == str.Length;
}