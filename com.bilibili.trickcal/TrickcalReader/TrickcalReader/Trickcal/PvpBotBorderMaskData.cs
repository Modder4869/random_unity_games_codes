using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PvpBotBorderMaskData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int UserProfileUid { get; set; }
    [Key(2)]
    public bool Available { get; set; }
}
