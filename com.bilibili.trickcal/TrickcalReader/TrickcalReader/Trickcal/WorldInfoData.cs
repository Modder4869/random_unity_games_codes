using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WorldInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ModeType Mode { get; set; }
    [Key(2)]
    public WorldUnlockType UnlockType { get; set; }
    [Key(3)]
    public int UnlockValue { get; set; }
    [Key(4)]
    public string Name { get; set; }
    [Key(5)]
    public string Desc { get; set; }
    [Key(6)]
    public int WorldBoss { get; set; }
    [Key(7)]
    public string WorldBackground { get; set; }
    [Key(8)]
    public float BackgroundSpeed { get; set; }
    [Key(9)]
    public WorldOpenCondition[] OpenConditions { get; set; }
    [Key(10)]
    public int[] RewardConditionIdArray { get; set; }
    [Key(11)]
    public int[] RewardItemArray { get; set; }
    [Key(12)]
    public int[] RewardValueArray { get; set; }
    [Key(13)]
    public int[] HardRewardConditionIdArray { get; set; }
    [Key(14)]
    public int[] HardRewardItemArray { get; set; }
    [Key(15)]
    public int[] HardRewardValueArray { get; set; }
    [Key(16)]
    public int[] VeryHardRewardConditionIdArray { get; set; }
    [Key(17)]
    public int[] VeryHardRewardItemArray { get; set; }
    [Key(18)]
    public int[] VeryHardRewardValueArray { get; set; }
    [Key(19)]
    public JobType[] Herolimit { get; set; }
    [Key(20)]
    public string TileImgName { get; set; }
    [Key(21)]
    public string WorldTile { get; set; }
    [Key(22)]
    public bool AutoStartNormal { get; set; }
    [Key(23)]
    public WorldLimitType TypeLimit { get; set; }
    [Key(24)]
    public bool AutoStartHard { get; set; }
    [Key(25)]
    public bool AutoStartVeryHard { get; set; }
    [Key(26)]
    public bool AutoStartChallenge { get; set; }
    [Key(27)]
    public bool FastNormal { get; set; }
    [Key(28)]
    public bool FastHard { get; set; }
    [Key(29)]
    public bool FastVeryHard { get; set; }
    [Key(30)]
    public bool FastChallenge { get; set; }
}
