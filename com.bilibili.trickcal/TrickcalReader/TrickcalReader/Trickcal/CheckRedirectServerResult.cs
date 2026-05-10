using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CheckRedirectServerResult {
    [Key(0)]
    public string ServerUrl { get; set; }
}
