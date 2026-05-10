using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetSoloRaidRankings {
    [Key(0)]
    public int SoloRaidId { get; set; }
    [Key(1)]
    public int Page { get; set; }
    [Key(2)]
    public int Length { get; set; }
}
