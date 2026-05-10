using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameLeetsWorldData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int StageGroup { get; set; }
    [Key(2)]
    public int MovingSpeed { get; set; }
    [Key(3)]
    public int SuccessBarSize { get; set; }
    [Key(4)]
    public NeedItemType SizeUpNeedItemType { get; set; }
    [Key(5)]
    public int SizeUpNeedItemUid { get; set; }
    [Key(6)]
    public int SizeUpNeedItemCount { get; set; }
    [Key(7)]
    public int PerSizeUp { get; set; }
    [Key(8)]
    public RewardType RewardType { get; set; }
    [Key(9)]
    public int RewardUid { get; set; }
    [Key(10)]
    public int RewardCount { get; set; }
    [Key(11)]
    public string Name { get; set; }
    [Key(12)]
    public string StageName { get; set; }
    [Key(13)]
    public string StageCount { get; set; }
    [Key(14)]
    public int SpecialSizeUp { get; set; }
    [Key(15)]
    public int ReduceSizeUp { get; set; }
    [Key(16)]
    public string StageResultCount { get; set; }
    [Key(17)]
    public string SpecialName { get; set; }
    [Key(18)]
    public string SpecialStageName { get; set; }
}
