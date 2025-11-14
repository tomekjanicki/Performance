using System.Collections.ObjectModel;

namespace Performance.B09ListManipulations;

public static class ListManipulations
{
    private static readonly ReadOnlyCollection<int> Data = [.. Enumerable.Range(0, 100000).Select(i => i)];

    public static ReadOnlyCollection<int> InsertItemsAtTheBeginningOneByOne(int count)
    {
        var data = Data.ToList();
        for (var counter = 0; counter < count; counter++)
        {
            data.Insert(0, counter);
        }

        return data.AsReadOnly();
    }
    
    public static ReadOnlyCollection<int> InsertItemsAtTheBeginningByRange(int count)
    {
        var data = Data.ToList();
        data.InsertRange(0, Enumerable.Range(0, count));
        
        return data.AsReadOnly();
    }
    
    public static ReadOnlyCollection<int> InsertItemsAtTheBeginningWithLinq(int count) =>
        [.. Enumerable.Range(0, count).Union(Data)];
    
    public static ReadOnlyCollection<int> RemoveItemsAtTheBeginningOneByOne(int count)
    {
        var data = Data.ToList();
        for (var counter = 0; counter < count; counter++)
        {
            data.RemoveAt(0);
        }

        return data.AsReadOnly();
    }

    public static ReadOnlyCollection<int> RemoveItemsAtTheBeginningByRange(int count)
    {
        var data = Data.ToList();
        data.RemoveRange(0, count);
 
        return data.AsReadOnly();
    }

    public static ReadOnlyCollection<int> RemoveItemsAtTheBeginningByLinq(int count) =>
        [.. Data.Skip(count)];
}