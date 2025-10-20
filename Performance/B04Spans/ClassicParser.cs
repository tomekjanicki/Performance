using System.Globalization;

namespace Performance.B04Spans;

#pragma warning disable CA1846
public static class ClassicParser
{
    public static IReadOnlyCollection<Result> Parse(string data)
    {
        var lines = data.Split(Environment.NewLine);

        return [.. lines.Select(static line => new Result
        {
            Field1 = int.Parse(line[..10], CultureInfo.InvariantCulture), 
            Field2 = int.Parse(line.Substring(10, 10), CultureInfo.InvariantCulture), 
            Field3 = int.Parse(line.Substring(20, 10), CultureInfo.InvariantCulture)
        })];
    }
}