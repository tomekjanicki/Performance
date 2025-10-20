using System.Globalization;

namespace Performance.B06Capacity;

public static class Processor
{
    public static readonly IReadOnlyCollection<int> Items = [.. Enumerable.Range(0, 10000)];
    
    public static IReadOnlyCollection<string> ProcessWithCapacity(IReadOnlyCollection<int> values)
    {
        var result = new List<string>(values.Count);
        foreach (var value in values)
        {
            result.Add((value * 2).ToString(CultureInfo.InvariantCulture));
        }
        
        return result;
    }
    
    public static IReadOnlyCollection<string> ProcessWithoutCapacity(IReadOnlyCollection<int> values)
    {
        var result = new List<string>();
        foreach (var value in values)
        {
            result.Add((value * 2).ToString(CultureInfo.InvariantCulture));
        }
        
        return result;
    }
}