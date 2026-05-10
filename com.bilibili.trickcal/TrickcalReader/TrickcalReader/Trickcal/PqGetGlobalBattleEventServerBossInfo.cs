using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetGlobalBattleEventServerBossInfo {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int GlobalBattleEventUid { get; set; }
}
