using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AugmentChallengeLevelData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Level { get; set; }
    [Key(3)]
    public int NeedExp { get; set; }
    [Key(4)]
    public int AugmentDropUid { get; set; }
    [Key(5)]
    public bool IsReroll { get; set; }
    [Key(6)]
    public int OptionValue { get; set; }
    [Key(7)]
    public string AugmentDropTitle { get; set; }
}
