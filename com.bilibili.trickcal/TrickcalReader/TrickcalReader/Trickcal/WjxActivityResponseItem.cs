using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WjxActivityResponseItem {
    [Key(0)]
    public int EventId { get; set; }
    [Key(1)]
    public int Lv { get; set; }
    [Key(2)]
    public List<WjxConfig> WjxConfigs { get; set; }
}
