using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace Performance.B13DictionaryAlternateLookup;

public static partial class Service
{
    private static readonly string Input = new HttpClient().GetStringAsync("https://gutenberg.org/cache/epub/2600/pg2600.txt").Result;

    [GeneratedRegex(@"\b\w+\b")]
    private static partial Regex WordParser();
    
    public static ReadOnlyDictionary<string, int> CountWords1()
    {
        ReadOnlySpan<char> input = Input;
        Dictionary<string, int> result = new(StringComparer.OrdinalIgnoreCase);
        foreach (var match in WordParser().EnumerateMatches(input))
        {
            var word = input.Slice(match.Index, match.Length);
            var key = word.ToString();
            result[key] = result.TryGetValue(key, out var count) ? count + 1 : 1;
        }

        return result.AsReadOnly();
    }

    public static ReadOnlyDictionary<string, int> CountWords2()
    {
        ReadOnlySpan<char> input = Input;
        Dictionary<string, int> result = new(StringComparer.OrdinalIgnoreCase);
        var alternate = result.GetAlternateLookup<ReadOnlySpan<char>>();
        foreach (var match in WordParser().EnumerateMatches(input))
        {
            var word = input.Slice(match.Index, match.Length);
            alternate[word] = alternate.TryGetValue(word, out var count) ? count + 1 : 1;
        }

        return result.AsReadOnly();
    }
}