using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetSoloEndClearInfos {
    [Key(0)]
    public int SoloEndId { get; set; }
    [Key(1)]
    public int StageId { get; set; }
    [Key(2)]
    public int Page { get; set; }
    [Key(3)]
    public int PageLength { get; set; }
}
