using System.Collections.ObjectModel;

namespace Performance.B16Batches;

public static class Service
{
    private static IEnumerable<int> GetValues(int count) => 
        Enumerable.Range(1, count);

    public static ReadOnlyCollection<int> GetWithChunks(int count, int chunkSize) => 
        GetValues(count).Chunk(chunkSize).Select(static chunk => chunk.Select(Processor).Sum()).ToList().AsReadOnly();

    public static ReadOnlyCollection<int> GetWithSkipTake(int count, int chunkSize)
    {
        var values = GetValues(count).ToArray();
        var counter = 0;
        var results = new List<int>(count / chunkSize + 1);
        while (true)
        {
            var chunk = values.Skip(counter * chunkSize).Take(chunkSize).ToArray();
            if (chunk.Length == 0)
            {
                break;
            }
            results.Add(chunk.Select(Processor).Sum());
            counter++;
        }
        
        return results.AsReadOnly();
    }
    
    private static int Processor(int value) => 
        value + 1;
}