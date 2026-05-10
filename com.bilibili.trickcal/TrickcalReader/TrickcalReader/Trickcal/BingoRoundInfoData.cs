using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BingoRoundInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Season { get; set; }
    [Key(2)]
    public int Round { get; set; }
    [Key(3)]
    public int RewardUid { get; set; }
    [Key(4)]
    public int RewardValue { get; set; }
    [Key(5)]
    public int NeedPoint { get; set; }
}
