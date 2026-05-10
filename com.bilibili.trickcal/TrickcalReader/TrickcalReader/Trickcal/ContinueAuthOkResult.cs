using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ContinueAuthOkResult {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public DateTime ServerTime { get; set; }
    [Key(2)]
    public string ServerVersion { get; set; }
    [Key(3)]
    public string TableVersion { get; set; }
}
