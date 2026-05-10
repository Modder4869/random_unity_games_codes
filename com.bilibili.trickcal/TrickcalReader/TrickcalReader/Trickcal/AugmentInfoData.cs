using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AugmentInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Name { get; set; }
    [Key(2)]
    public bool IsTierAugment { get; set; }
    [Key(3)]
    public bool Repetition { get; set; }
    [Key(4)]
    public DrawAugmentCondition DrawCondition { get; set; }
    [Key(5)]
    public int DrawConditionValue { get; set; }
    [Key(6)]
    public bool IsAddOn { get; set; }
    [Key(7)]
    public int AddOnTargetUid { get; set; }
    [Key(8)]
    public string AugmentAction { get; set; }
    [Key(9)]
    public string Icon { get; set; }
    [Key(10)]
    public int[] RequiredAugmentLevels { get; set; }
    [Key(11)]
    public string SubIcon { get; set; }
    [Key(12)]
    public string ConditionIcon { get; set; }
    [Key(13)]
    public int AugmentType { get; set; }
    [Key(14)]
    public int ActiveDuration { get; set; }
    [Key(15)]
    public AugmentGetType AugmentGetType { get; set; }
    [Key(16)]
    public int[] RequiredAugmentUids { get; set; }
    [Key(17)]
    public int NoticeHeroUid { get; set; }
}
