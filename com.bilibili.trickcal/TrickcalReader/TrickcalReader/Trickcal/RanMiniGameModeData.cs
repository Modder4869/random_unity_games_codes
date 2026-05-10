using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RanMiniGameModeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public float PlayTime { get; set; }
    [Key(2)]
    public float AppearPerTime { get; set; }
    [Key(3)]
    public float AppearSpeedIncrease { get; set; }
    [Key(4)]
    public float AppearSpeedTime { get; set; }
    [Key(5)]
    public int AppearRateIncrease { get; set; }
    [Key(6)]
    public float AppearRateTime { get; set; }
    [Key(7)]
    public float AppearHelpTimeMin { get; set; }
    [Key(8)]
    public float AppearHelpTimeMax { get; set; }
    [Key(9)]
    public int AppearHelpAmountMin { get; set; }
    [Key(10)]
    public int AppearHelpAmountMax { get; set; }
    [Key(11)]
    public float HelpSpeedIncrease { get; set; }
    [Key(12)]
    public int HelpSpeedTime { get; set; }
    [Key(13)]
    public float AppearPerTimeMin { get; set; }
    [Key(14)]
    public float AppearPerTimeMax { get; set; }
    [Key(15)]
    public int BonusGroup { get; set; }
    [Key(16)]
    public float SkillUid { get; set; }
    [Key(17)]
    public string ModeName { get; set; }
    [Key(18)]
    public string ModeDesc { get; set; }
    [Key(19)]
    public string Prefab { get; set; }
}
