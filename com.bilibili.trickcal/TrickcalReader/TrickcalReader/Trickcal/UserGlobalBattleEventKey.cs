using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserGlobalBattleEventKey {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int GlobalBattleEventUid { get; set; }
}
