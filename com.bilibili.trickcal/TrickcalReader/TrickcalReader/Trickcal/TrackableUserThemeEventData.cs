using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserThemeEventData {
    [Key(0)]
    public int[] NormalStageClearDeckBonuses { get; set; }
}
