using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqKeepAliveTowerBattleRoom {
    [Key(0)]
    public int SeasonId { get; set; }
}
