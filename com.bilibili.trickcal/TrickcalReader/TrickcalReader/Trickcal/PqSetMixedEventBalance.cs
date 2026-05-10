using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetMixedEventBalance {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int BalanceInfoUid { get; set; }
    [Key(2)]
    public short[] Balances { get; set; }
}
