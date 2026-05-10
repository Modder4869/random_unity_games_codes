using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UINPCClosetData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Sort { get; set; }
    [Key(2)]
    public int NpcUid { get; set; }
    [Key(3)]
    public string Icon { get; set; }
    [Key(4)]
    public string Text { get; set; }
}
