using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserGlobalBattleEventBossData {
    [Key(0)]
    public long TodayMaxDamage { get; set; }
    [Key(1)]
    public bool IsPlayed { get; set; }
    [Key(2)]
    public bool IsCleared { get; set; }
    [Key(3)]
    public DateTime LastPlayTime { get; set; }
}
