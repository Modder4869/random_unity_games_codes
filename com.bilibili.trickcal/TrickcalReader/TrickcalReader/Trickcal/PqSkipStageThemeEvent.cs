using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSkipStageThemeEvent {
    [Key(0)]
    public int ThemeEventUid { get; set; }
    [Key(1)]
    public int StageUid { get; set; }
    [Key(2)]
    public int SkipCount { get; set; }
}
