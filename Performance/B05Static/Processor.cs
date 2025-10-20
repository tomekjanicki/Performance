namespace Performance.B05Static;

public static class Processor
{
    private static readonly int[] Values = [.. Enumerable.Range(1, 100)];

    public static IReadOnlyCollection<int> GetValidValuesNotStatic() =>
        [.. Values.Where(Validator.IsValidNotStatic)];
    
    public static IReadOnlyCollection<int> GetValidValuesStatic() =>
        [.. Values.Where(Validator.IsValidStatic)];
}