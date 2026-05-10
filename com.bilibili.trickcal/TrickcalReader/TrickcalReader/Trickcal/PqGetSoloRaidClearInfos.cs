using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetSoloRaidClearInfos {
    [Key(0)]
    public int SoloRaidId { get; set; }
    [Key(1)]
    public int UserId { get; set; }
    [Key(2)]
    public short PageIndex { get; set; }
    [Key(3)]
    public short Count { get; set; }
}
