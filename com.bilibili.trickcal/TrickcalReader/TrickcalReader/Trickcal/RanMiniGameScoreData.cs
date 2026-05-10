using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RanMiniGameScoreData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Resource { get; set; }
    [Key(2)]
    public int AppearRate { get; set; }
    [Key(3)]
    public int AddScore { get; set; }
    [Key(4)]
    public int LoseScore { get; set; }
    [Key(5)]
    public int DelayEffectTime { get; set; }
    [Key(6)]
    public int ScoreEffectTime { get; set; }
    [Key(7)]
    public int ScoreEffectRate { get; set; }
    [Key(8)]
    public float IncreaseTime { get; set; }
    [Key(9)]
    public float DecreaseTime { get; set; }
    [Key(10)]
    public int FeverIncrease { get; set; }
    [Key(11)]
    public int FeverDecrease { get; set; }
    [Key(12)]
    public float SizeRate { get; set; }
    [Key(13)]
    public int FeverRate { get; set; }
    [Key(14)]
    public string SFX { get; set; }
    [Key(15)]
    public int AppearHelpRate { get; set; }
    [Key(16)]
    public int ModeUid { get; set; }
    [Key(17)]
    public RanMiniGameItemType Type { get; set; }
    [Key(18)]
    public int SkillUid { get; set; }
    [Key(19)]
    public string Name { get; set; }
    [Key(20)]
    public string Desc { get; set; }
}
