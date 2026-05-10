using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableBaseCardData {
    [Key(0)]
    public bool DefaultHold { get; set; }
    [Key(1)]
    public int GetRewardItemUid { get; set; }
    [Key(2)]
    public int GetRewardValue { get; set; }
    [Key(3)]
    public int LevelUpCondition { get; set; }
}
