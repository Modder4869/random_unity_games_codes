using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChatInfo : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ChatGroupUid { get; set; }
    [Key(2)]
    public int ChatUIUid { get; set; }
    [Key(3)]
    public ContentsUnlockType[] UnlockTypes { get; set; }
    [Key(4)]
    public int[] UnlockValues { get; set; }
    [Key(5)]
    public int[] UnlockExtraValues { get; set; }
}
