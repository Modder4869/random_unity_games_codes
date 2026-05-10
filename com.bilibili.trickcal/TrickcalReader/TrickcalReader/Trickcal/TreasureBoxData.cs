using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TreasureBoxData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public TreasureBoxType Type { get; set; }
    [Key(2)]
    public int Drop { get; set; }
    [Key(3)]
    public int UseNum { get; set; }
    [Key(4)]
    public TreasureBoxGradeType TreasureBoxGradeType { get; set; }
    [Key(5)]
    public int TreasureBoxCondition { get; set; }
    [Key(6)]
    public RewardPopupType RewardPopupType { get; set; }
    [Key(7)]
    public bool IsProb { get; set; }
    [Key(8)]
    public PreviewUIType PreviewUI { get; set; }
    [Key(9)]
    public string PopupDesc { get; set; }
}
