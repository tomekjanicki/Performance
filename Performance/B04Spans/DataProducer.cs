using System.Globalization;

namespace Performance.B04Spans;

public static class DataProducer
{
    public static string GetData(int rowCount) => 
        string.Join(Environment.NewLine, Enumerable.Range(0, rowCount).Select(i => $"{i.ToString(CultureInfo.InvariantCulture).PadLeft(10, '0')}{i.ToString(CultureInfo.InvariantCulture).PadLeft(10, '0')}{i.ToString(CultureInfo.InvariantCulture).PadLeft(10, '0')}"));
}