using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LabEffectStat {
    [Key(0)]
    public int LabReduceTimePercent100 { get; set; }
    [Key(1)]
    public int ResearchSlotCountAdd { get; set; }
    [Key(2)]
    public int ScheduleDailyTaskCountAdd { get; set; }
    [Key(3)]
    public int ScheduleTaskListCountAdd { get; set; }
    [Key(4)]
    public int ScheduleTaskMinSuccessRatePercent100 { get; set; }
    [Key(5)]
    public int DonationFixedRewardPercent100 { get; set; }
    [Key(6)]
    public TimeSpan DonationMaxTimeAdd { get; set; }
    [Key(7)]
    public int[] AttackPhysicUp { get; set; }
    [Key(8)]
    public int[] AttackMagicUp { get; set; }
    [Key(9)]
    public int[] DefensePhysicUp { get; set; }
    [Key(10)]
    public int[] DefenseMagicUp { get; set; }
    [Key(11)]
    public int[] HpUp { get; set; }
    [Key(12)]
    public int DefaultManaAdd { get; set; }
    [Key(13)]
    public int RestaurantSlotCountAdd { get; set; }
    [Key(14)]
    public int SoloRaidArtifactCountUp { get; set; }
    [Key(15)]
    public int SoloEndDefaultCoinUp { get; set; }
    [Key(16)]
    public int ArtifactManageSlotUp { get; set; }
    [Key(17)]
    public int SpellManageSlotUp { get; set; }
    [Key(18)]
    public int BattleGemValueUp { get; set; }
    [Key(19)]
    public int FarmGoldValueUp { get; set; }
    [Key(20)]
    public int FarmGuildCurrencyValueUp { get; set; }
    [Key(21)]
    public int LoveHeroValueUp { get; set; }
}
