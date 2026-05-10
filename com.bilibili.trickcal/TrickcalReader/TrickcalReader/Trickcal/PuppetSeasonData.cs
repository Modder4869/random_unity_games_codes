using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PuppetSeasonData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Season { get; set; }
    [Key(2)]
    public int HelpUid { get; set; }
    [Key(3)]
    public bool IsStoryNavigation { get; set; }
}
