using System.Text;
using System.Text.Json;

namespace Performance.B12Serialization;

public static class Service
{
    private static readonly IReadOnlyCollection<Dto> Dtos = [.. Enumerable.Range(0, 1000).Select(i => new Dto
    {
        Value = i
    })];
    
    private static readonly byte[] DtosUtf8 = JsonSerializer.SerializeToUtf8Bytes(Dtos);

    public static byte[] SerializeDirectlyToUtf8() =>
        JsonSerializer.SerializeToUtf8Bytes(Dtos);

    public static byte[] SerializeToStringToUtf8() =>
        Encoding.UTF8.GetBytes(JsonSerializer.Serialize(Dtos));
    
    public static IReadOnlyCollection<Dto> DeserializeDirectlyFromUtf8() =>
        JsonSerializer.Deserialize<IReadOnlyCollection<Dto>>(DtosUtf8)!;

    public static IReadOnlyCollection<Dto> DeserializeFromUtf8FromString() =>
        JsonSerializer.Deserialize<IReadOnlyCollection<Dto>>(Encoding.UTF8.GetString(DtosUtf8))!;
}