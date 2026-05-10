using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetWWEBetInfo {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public int Round { get; set; }
}
