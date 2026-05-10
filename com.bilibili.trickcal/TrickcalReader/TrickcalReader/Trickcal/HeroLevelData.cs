using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroLevelData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroInfoUid { get; set; }
    [Key(2)]
    public TableBaseStatData Stat { get; set; }
    [Key(3)]
    public TableBaseStatIncreaseData StatIncrease { get; set; }
    [Key(4)]
    public int DefaultSp { get; set; }
    [Key(5)]
    public int RecoveryHitSp { get; set; }
    [Key(6)]
    public float ToleranceGroggy { get; set; }
    [Key(7)]
    public float ToleranceDebuff { get; set; }
    [Key(8)]
    public float ToleranceDOT { get; set; }
    [Key(9)]
    public bool ImmuneStiffen { get; set; }
    [Key(10)]
    public bool ImmunePush { get; set; }
    [Key(11)]
    public bool ImmuneKnockBack { get; set; }
}
