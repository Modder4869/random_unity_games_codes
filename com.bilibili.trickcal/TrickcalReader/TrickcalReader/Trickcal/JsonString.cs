using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct JsonString {
    [Key(0)]
    public string Str { get; set; }
}
