using System.Collections.ObjectModel;

namespace Performance.B05Static;

public static class Processor
{
    private static readonly int[] Values = [.. Enumerable.Range(1, 100)];

    public static ReadOnlyCollection<int> GetValidValuesNotStatic() =>
        [.. Values.Where(Validator.IsValidNotStatic)];
    
    public static ReadOnlyCollection<int> GetValidValuesStatic() =>
        [.. Values.Where(Validator.IsValidStatic)];
}