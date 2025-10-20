namespace Performance.B14Structs;

public static class Generator
{
    public static IReadOnlyDictionary<KeyAsRecordStruct, int> GetDictionaryKeyAsRecordStruct(int qty)
    {
        var results = new Dictionary<KeyAsRecordStruct, int>();
        for (var counter = 0; counter < qty; counter++)
        {
            results.Add(new KeyAsRecordStruct(counter, counter, Guid.NewGuid()), counter);
        }

        return results;
    }
    
    public static IReadOnlyDictionary<KeyAsStruct, int> GetDictionaryKeyAsStruct(int qty)
    {
        var results = new Dictionary<KeyAsStruct, int>();
        for (var counter = 0; counter < qty; counter++)
        {
            results.Add(new KeyAsStruct { Value1 = counter, Value2 = counter, Value3 = Guid.NewGuid() }, counter);
        }

        return results;
    }
}