using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LobbyBattleBtnData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public bool IsDefault { get; set; }
    [Key(2)]
    public int Sort { get; set; }
    [Key(3)]
    public string BattleBtnCharacter { get; set; }
    [Key(4)]
    public string[] BattleBtnVoice { get; set; }
    [Key(5)]
    public string[] EffectName { get; set; }
    [Key(6)]
    public int[] EffectX { get; set; }
    [Key(7)]
    public int[] EffectY { get; set; }
    [Key(8)]
    public int[] EffectZ { get; set; }
    [Key(9)]
    public string BattleBtnMaterialName { get; set; }
}
