using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CommunityMasterData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string IconRes { get; set; }
    [Key(2)]
    public string Server { get; set; }
    [Key(3)]
    public string Link { get; set; }
}
