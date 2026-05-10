using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetAttributeRankData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string RankString { get; set; }
    [Key(2)]
    public string ColorCode { get; set; }
    [Key(3)]
    public int RankConditionMinValue { get; set; }
}
