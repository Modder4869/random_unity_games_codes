using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetChaosArenaDefenseDeck {
    [Key(0)]
    public int ChaosArenaSeasonId { get; set; }
    [Key(1)]
    public short SelectedDefenseDeckIndex { get; set; }
}
