using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MinigameVelaEndingData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int MinScore { get; set; }
    [Key(2)]
    public int MaxScore { get; set; }
    [Key(3)]
    public string EndingLine { get; set; }
    [Key(4)]
    public string EndingVoice { get; set; }
    [Key(5)]
    public int UnitUid { get; set; }
    [Key(6)]
    public string UnitSkinKey { get; set; }
    [Key(7)]
    public string UnitSkin { get; set; }
    [Key(8)]
    public string UnitMotion { get; set; }
    [Key(9)]
    public string EndingImage { get; set; }
    [Key(10)]
    public string EndingText { get; set; }
}
