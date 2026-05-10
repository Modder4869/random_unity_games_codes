using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetDispatchAttributeRankData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string RankImage { get; set; }
    [Key(2)]
    public int RankConditionMinValue { get; set; }
}
