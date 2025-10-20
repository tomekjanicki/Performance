using EnumFastToStringGenerated;

namespace Performance.B02Enums;

public static class EnumService
{
    public static string ToStringStandard(TestType1 value) => 
        value.ToString();
    
    public static string ToStringSourceGenerated(TestType2 value) => 
        value.ToStringFast();

    public static bool TryParseStandard(string value, out TestType1 type1) =>
        Enum.TryParse(value, out type1);

    public static bool TryParseSourceGenerated(string value, out TestType2 type2) =>
        TestType2EnumExtensions.TryParseFast(value, out type2);
}