using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrTestRefreshLoginData {
    [Key(0)]
    public LoginData LoginData { get; set; }
}
