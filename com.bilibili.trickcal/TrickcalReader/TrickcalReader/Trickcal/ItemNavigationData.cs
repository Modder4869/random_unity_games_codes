using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ItemNavigationData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ItemNavigationType Type { get; set; }
    [Key(2)]
    public string TitleKey { get; set; }
    [Key(3)]
    public string CategoryKey { get; set; }
    [Key(4)]
    public string DescKey { get; set; }
    [Key(5)]
    public bool DefaultContents { get; set; }
}
