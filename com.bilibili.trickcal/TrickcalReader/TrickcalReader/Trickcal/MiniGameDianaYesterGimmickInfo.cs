using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameDianaYesterGimmickInfo : TableItem<TableData> {
    [Key(1)]
    public int StageUid { get; set; }
    [Key(2)]
    public int MaxGaugeValue { get; set; }
    [Key(3)]
    public MiniGameDianaAddGaugeType[] AddGaugeType { get; set; }
    [Key(4)]
    public int[] AddGaugeValue { get; set; }
    [Key(5)]
    public int ActivateTakenTime { get; set; }
    [Key(6)]
    public int BlackSpellGroupUid { get; set; }
    [Key(7)]
    public string PrepareText { get; set; }
    [Key(8)]
    public string ProgressText { get; set; }
}
