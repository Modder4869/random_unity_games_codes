using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MixedEventContentsLockData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int MixedEventUid { get; set; }
    [Key(2)]
    public MixedEventContentsType ContentsType { get; set; }
    [Key(3)]
    public ContentsUnlockType UnlockType { get; set; }
    [Key(4)]
    public int UnlockValue { get; set; }
}
