using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChatEventUIInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ChatEventContentsType ChatContentsType { get; set; }
    [Key(2)]
    public string BGM { get; set; }
}
