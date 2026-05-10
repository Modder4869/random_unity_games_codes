using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class Theme17ModeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int MaximumScore { get; set; }
    [Key(2)]
    public ContentsUnlockType UnlockType { get; set; }
    [Key(3)]
    public int UnlockValue { get; set; }
    [Key(4)]
    public string ModeName { get; set; }
}
