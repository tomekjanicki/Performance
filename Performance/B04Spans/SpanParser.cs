using System.Globalization;

namespace Performance.B04Spans;

public static class SpanParser
{
    public static IReadOnlyCollection<Result> Parse(string data)
    {
        var span = data.AsSpan();
        var lineRanges = span.Split(Environment.NewLine);
        var result = new List<Result>();
        foreach (var lineRange in lineRanges)
        {
            result.Add(new Result
            {
                Field1 = int.Parse(span.Slice(lineRange.Start.Value, 10), CultureInfo.InvariantCulture),
                Field2 = int.Parse(span.Slice(lineRange.Start.Value + 10, 10), CultureInfo.InvariantCulture),
                Field3 = int.Parse(span.Slice(lineRange.Start.Value + 20, 10), CultureInfo.InvariantCulture)
            });
        }

        return result;
    }
}