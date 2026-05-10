using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventCardEditInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int DrawGroup { get; set; }
    [Key(2)]
    public int MaxCardCost { get; set; }
    [Key(3)]
    public int MinCardCount { get; set; }
    [Key(4)]
    public int OpenDelayHours { get; set; }
    [Key(5)]
    public ContentsUnlockType UnlockType { get; set; }
    [Key(6)]
    public int UnlockValue { get; set; }
}
