namespace Performance.B15Streams;

public static class Generator
{
    public static void Save(string fileName, int rowCount)
    {
        var rows = GetRows(rowCount);
        File.WriteAllBytes(fileName, rows);
    }
    
    private static byte[] GetRows(int rowCount) =>
        Enumerable.Range(0, rowCount).Select(static _ => GetRow()).SelectMany(static bytes => bytes).ToArray();
    
    private static byte[] GetRow() =>
        [(byte)Random.Shared.Next(0, 255), (byte)Random.Shared.Next(0, 255), (byte)Random.Shared.Next(0, 255)];
}