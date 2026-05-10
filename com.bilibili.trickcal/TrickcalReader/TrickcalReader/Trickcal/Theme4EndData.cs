using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class Theme4EndData : TableItem<TableData> {
    [Key(0)]
    public MiniGameEndType EndType { get; set; }
    [Key(1)]
    public int Star { get; set; }
    [Key(2)]
    public int Score { get; set; }
    [Key(3)]
    public string Review { get; set; }
    [Key(4)]
    public string Ani { get; set; }
    [Key(5)]
    public string EndingVoice { get; set; }
}
