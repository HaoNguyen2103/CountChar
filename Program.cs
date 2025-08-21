public class Program
{
    static Dictionary<char, int> CountCharacters(string input)

    {
        Dictionary<char, int> characterCount = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (characterCount.ContainsKey(c))
            {
                characterCount[c]++;
            }
            else
            {
                characterCount[c] = 1;
            }
        }
        return characterCount;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Input String");
        string input = Console.ReadLine() ?? "";
        Dictionary<char, int> result = CountCharacters(input);
        Console.WriteLine("Character Count:");
        foreach (var pair in result)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}