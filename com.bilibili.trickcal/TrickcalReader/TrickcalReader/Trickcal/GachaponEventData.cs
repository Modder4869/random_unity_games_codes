using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaponEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string BackGround { get; set; }
    [Key(2)]
    public string PeriodColor { get; set; }
    [Key(3)]
    public string TitleText { get; set; }
    [Key(4)]
    public string TitleImage { get; set; }
    [Key(5)]
    public int EventGoodsUid { get; set; }
    [Key(6)]
    public int EventGoodsUsage { get; set; }
    [Key(7)]
    public int InteractionGroupUid { get; set; }
    [Key(8)]
    public string Bgm { get; set; }
    [Key(9)]
    public int[] DropGroupUid { get; set; }
    [Key(10)]
    public int[] DropWeight { get; set; }
    [Key(11)]
    public int HelpUid { get; set; }
}
