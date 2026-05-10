using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveGlobalBattleEventServerBossRewards {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int GlobalBattleEventUid { get; set; }
    [Key(2)]
    public int Step { get; set; }
}
