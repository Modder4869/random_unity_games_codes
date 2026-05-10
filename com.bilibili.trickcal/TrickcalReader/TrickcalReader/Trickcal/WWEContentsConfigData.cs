using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEContentsConfigData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int WWEId { get; set; }
    [Key(2)]
    public WWEContentsType ContentsType { get; set; }
    [Key(3)]
    public int HelpUid { get; set; }
    [Key(4)]
    public string TitleText { get; set; }
    [Key(5)]
    public string BGM1 { get; set; }
    [Key(6)]
    public string BGM2 { get; set; }
    [Key(7)]
    public int[] CurrencyUid { get; set; }
}
