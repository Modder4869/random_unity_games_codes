using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrContinueLogin {
    [Key(0)]
    public LoginData LoginData { get; set; }
    [Key(1)]
    public string ContinueAuthToken { get; set; }
}
