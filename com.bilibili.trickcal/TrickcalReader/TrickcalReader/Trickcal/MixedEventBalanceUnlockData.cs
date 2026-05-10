using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MixedEventBalanceUnlockData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int BalanceInfoUid { get; set; }
    [Key(2)]
    public ContentsUnlockType UnlockType { get; set; }
    [Key(3)]
    public int UnlockValue { get; set; }
    [Key(4)]
    public int UnlockExtraValue { get; set; }
}
