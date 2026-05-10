using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WjxConfig {
    [Key(0)]
    public int ActivityId { get; set; }
    [Key(1)]
    public LanguageType Lang { get; set; }
    [Key(2)]
    public string Url { get; set; }
}
