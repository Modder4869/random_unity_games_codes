using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonContentsConfigData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ContentsUid { get; set; }
    [Key(2)]
    public CookingTycoonContentsType ContentsType { get; set; }
    [Key(3)]
    public string TitleText { get; set; }
    [Key(4)]
    public string[] BGMs { get; set; }
    [Key(5)]
    public int HelpUid { get; set; }
    [Key(6)]
    public int[] CurrencyItemUids { get; set; }
}
