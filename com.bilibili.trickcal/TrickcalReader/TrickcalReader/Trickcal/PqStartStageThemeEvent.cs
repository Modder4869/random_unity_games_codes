using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartStageThemeEvent {
    [Key(0)]
    public int ThemeEventUid { get; set; }
    [Key(1)]
    public int StageUid { get; set; }
    [Key(2)]
    public PlayDeckData PlayDeckData { get; set; }
    [Key(3)]
    public bool IsAutoPlay { get; set; }
    [Key(4)]
    public bool IsFastBattle { get; set; }
}
