using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ContentsNoticeData : TableItem<TableData> {
    [Key(0)]
    public ContentsNoticeType Type { get; set; }
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public string PopUpDesc { get; set; }
    [Key(3)]
    public string PrefabName { get; set; }
    [Key(4)]
    public UnitType UnitType { get; set; }
    [Key(5)]
    public int UnitUid { get; set; }
    [Key(6)]
    public string Skin { get; set; }
    [Key(7)]
    public bool Flip { get; set; }
    [Key(8)]
    public float PosX { get; set; }
    [Key(9)]
    public float PosY { get; set; }
    [Key(10)]
    public float Scale { get; set; }
    [Key(11)]
    public string UnitStartAni { get; set; }
    [Key(12)]
    public string UnitLoopAni { get; set; }
}
