using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TermsOfServiceData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Type { get; set; }
    [Key(2)]
    public int Order { get; set; }
    [Key(3)]
    public string Title { get; set; }
    [Key(4)]
    public string Link { get; set; }
    [Key(5)]
    public string TermsType { get; set; }
}
