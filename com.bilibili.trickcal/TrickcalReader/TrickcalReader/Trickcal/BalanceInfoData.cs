using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BalanceInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public MixedEventBalanceTeamType[] TeamTypes { get; set; }
    [Key(2)]
    public int InteractionUid { get; set; }
}
