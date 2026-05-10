using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndThemeEvent {
    [Key(0)]
    public int ThemeEventUid { get; set; }
}
