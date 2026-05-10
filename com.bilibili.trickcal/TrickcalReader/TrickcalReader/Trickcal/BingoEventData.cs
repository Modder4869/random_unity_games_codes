using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BingoEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Season { get; set; }
    [Key(2)]
    public int EventGoodsUid { get; set; }
    [Key(3)]
    public int EventGoodsUsage { get; set; }
    [Key(4)]
    public string BackGround { get; set; }
    [Key(5)]
    public string PeriodColorString { get; set; }
    [Key(6)]
    public string TitleText { get; set; }
    [Key(7)]
    public string TitleImage { get; set; }
    [Key(8)]
    public string TitleImageFX { get; set; }
    [Key(10)]
    public int DropGroup { get; set; }
    [Key(11)]
    public int Interaction { get; set; }
    [Key(12)]
    public bool IsMainLobby { get; set; }
    [Key(13)]
    public BingoType BingoType { get; set; }
    [Key(14)]
    public int BingoSize { get; set; }
    [Key(15)]
    public string Prefab { get; set; }
}
