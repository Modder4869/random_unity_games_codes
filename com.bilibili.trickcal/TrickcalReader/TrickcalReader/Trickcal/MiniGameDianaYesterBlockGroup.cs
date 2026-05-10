using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameDianaYesterBlockGroup : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int BlockGroupUid { get; set; }
    [Key(2)]
    public int BlockUid { get; set; }
}
