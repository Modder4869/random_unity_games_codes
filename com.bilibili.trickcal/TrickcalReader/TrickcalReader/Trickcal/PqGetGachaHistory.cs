using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetGachaHistory {
    [Key(0)]
    public GachaCategoryType? GachaCategory { get; set; }
    [Key(1)]
    public int Page { get; set; }
    [Key(2)]
    public int Length { get; set; }
}
