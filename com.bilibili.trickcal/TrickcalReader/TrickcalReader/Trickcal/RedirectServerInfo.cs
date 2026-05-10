using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RedirectServerInfo {
    [Key(0)]
    public CheckRedirectServerResult CheckRedirectServerResult { get; set; }
}
