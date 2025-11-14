using System.Collections.ObjectModel;
using System.Globalization;

namespace Performance.B06Capacity;

public static class Processor
{
    public static readonly ReadOnlyCollection<int> Items = [.. Enumerable.Range(0, 10000)];
    
    public static ReadOnlyCollection<string> ProcessWithCapacity(ReadOnlyCollection<int> values)
    {
        var result = new List<string>(values.Count);
        foreach (var value in values)
        {
            result.Add((value * 2).ToString(CultureInfo.InvariantCulture));
        }
        
        return result.AsReadOnly();
    }
    
    public static ReadOnlyCollection<string> ProcessWithoutCapacity(ReadOnlyCollection<int> values)
    {
        var result = new List<string>();
        foreach (var value in values)
        {
            result.Add((value * 2).ToString(CultureInfo.InvariantCulture));
        }
        
        return result.AsReadOnly();
    }
}