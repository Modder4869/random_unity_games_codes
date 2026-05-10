using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DailyRewardsData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Day { get; set; }
    [Key(2)]
    public string Dialogue { get; set; }
    [Key(3)]
    public string Spine { get; set; }
    [Key(4)]
    public string Animation { get; set; }
    [Key(5)]
    public RewardType[] RewardType { get; set; }
    [Key(6)]
    public int[] RewardUid { get; set; }
    [Key(7)]
    public int[] RewardValue { get; set; }
    [Key(8)]
    public int SkinUid { get; set; }
    [Key(9)]
    public int HeroUid { get; set; }
    [Key(10)]
    public string SkinKey { get; set; }
    [Key(11)]
    public bool SpecialDay { get; set; }
    [Key(12)]
    public int StandingSpineIndex { get; set; }
}
