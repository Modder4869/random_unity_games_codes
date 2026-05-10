using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroMotionExperienceEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public int PickUpUid { get; set; }
    [Key(3)]
    public string IntroUrl { get; set; }
    [Key(4)]
    public int HeroUid { get; set; }
    [Key(5)]
    public RewardType RewardType { get; set; }
    [Key(6)]
    public int RewardUid { get; set; }
    [Key(7)]
    public int RewardValue { get; set; }
    [Key(8)]
    public int MultiUid { get; set; }
    [Key(9)]
    public int MultiSort { get; set; }
}
