using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LobbyInfoData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public LobbyType Type { get; set; }
    [Key(2)]
    public bool IsDefault { get; set; }
    [Key(3)]
    public int RerunUid { get; set; }
    [Key(4)]
    public int InteractionGroup { get; set; }
    [Key(5)]
    public string Resource { get; set; }
    [Key(6)]
    public string BGM { get; set; }
    [Key(7)]
    public string TransitionColor { get; set; }
    [Key(8)]
    public bool IsAlwaysOwned { get; set; }
    [Key(9)]
    public string ListImage { get; set; }
    [Key(10)]
    public float Scale { get; set; }
    [Key(11)]
    public int TrialBattleBtnItemUid { get; set; }
    [Key(12)]
    public int[] RecommendBattleBtnUid { get; set; }
    [Key(13)]
    public string InteractionStart { get; set; }
}
