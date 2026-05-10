using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloRaidInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int WorldInfoUid { get; set; }
    [Key(2)]
    public int[] SeasonRuleUid { get; set; }
    [Key(3)]
    public int DrawGroup { get; set; }
    [Key(4)]
    public bool IsRealDeleted { get; set; }
    [Key(5)]
    public GroupType GroupType { get; set; }
}
