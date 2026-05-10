using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PvpBotBorderlineData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int UserBorderlineUid { get; set; }
    [Key(2)]
    public bool Available { get; set; }
}
