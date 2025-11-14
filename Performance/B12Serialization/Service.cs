using System.Collections.ObjectModel;
using System.Text;
using System.Text.Json;

namespace Performance.B12Serialization;

public static class Service
{
    private static readonly ReadOnlyCollection<Dto> Dtos = [.. Enumerable.Range(0, 1000).Select(i => new Dto
    {
        Value = i
    })];
    
    private static readonly ReadOnlyMemory<byte> DtosUtf8 = JsonSerializer.SerializeToUtf8Bytes(Dtos);

    public static ReadOnlyMemory<byte> SerializeDirectlyToUtf8() =>
        JsonSerializer.SerializeToUtf8Bytes(Dtos);

    public static ReadOnlyMemory<byte> SerializeToStringToUtf8() =>
        Encoding.UTF8.GetBytes(JsonSerializer.Serialize(Dtos));
    
    public static ReadOnlyCollection<Dto> DeserializeDirectlyFromUtf8() =>
        JsonSerializer.Deserialize<List<Dto>>(DtosUtf8.Span)!.AsReadOnly();

    public static ReadOnlyCollection<Dto> DeserializeFromUtf8FromString() =>
        JsonSerializer.Deserialize<List<Dto>>(Encoding.UTF8.GetString(DtosUtf8.Span))!.AsReadOnly();
}