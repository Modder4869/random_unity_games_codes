using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrLogin {
    [Key(0)]
    public LoginData LoginData { get; set; }
    [Key(1)]
    public string ContinueAuthToken { get; set; }
    [Key(2)]
    public int DayChangeCount { get; set; }
}
