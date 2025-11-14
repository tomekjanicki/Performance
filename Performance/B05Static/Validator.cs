using System.Collections.ObjectModel;

namespace Performance.B05Static;

public static class Validator
{
    private static readonly ReadOnlySet<int> ValidValues = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    public static bool IsValidStatic(int value) =>
        IsValid(value, ValidValues);

    public static bool IsValidNotStatic(int value) =>
        IsValid(value, [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
    
    private static bool IsValid(int value, ReadOnlySet<int> validValues) =>
        validValues.Contains(value);
}