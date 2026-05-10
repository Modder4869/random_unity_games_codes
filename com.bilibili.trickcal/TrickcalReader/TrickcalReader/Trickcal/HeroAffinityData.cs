using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroAffinityData : TableItem<TableData> {
    [Key(0)]
    public int HeroInfoUid { get; set; }
    [Key(1)]
    public int AffinityLv { get; set; }
    [Key(2)]
    public StatType[] StatusName { get; set; }
    [Key(3)]
    public int[] StatusValue { get; set; }
}
