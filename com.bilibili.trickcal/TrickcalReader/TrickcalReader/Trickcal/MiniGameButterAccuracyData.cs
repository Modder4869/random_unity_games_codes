using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameButterAccuracyData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ButterMiniGameAccuracyGradeType AccuracyGradeType { get; set; }
    [Key(2)]
    public int AccuracyRangeMsMin { get; set; }
    [Key(3)]
    public int AccuracyRangeMsMax { get; set; }
    [Key(4)]
    public int HpValue { get; set; }
    [Key(5)]
    public int ScoreValue { get; set; }
    [Key(6)]
    public int FeverValue { get; set; }
    [Key(7)]
    public bool IsComboReset { get; set; }
    [Key(8)]
    public string PlayerUnitSpineAni { get; set; }
    [Key(9)]
    public string VFX { get; set; }
    [Key(10)]
    public string SFX { get; set; }
}
