using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEnterThemeEventFirst {
    [Key(0)]
    public int ThemeEventUid { get; set; }
}
