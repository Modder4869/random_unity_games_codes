using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqChangeTowerBattleObject {
    [Key(0)]
    public int SeasonId { get; set; }
}
