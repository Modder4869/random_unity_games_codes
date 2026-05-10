using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattleEmotionData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public TowerBattleEmotionType Type { get; set; }
    [Key(2)]
    public string Voice { get; set; }
    [Key(3)]
    public string Ani1 { get; set; }
    [Key(4)]
    public string Ani2 { get; set; }
}
