using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetChaosArenaDefenseDeck {
    [Key(0)]
    public int ChaosArenaSeasonId { get; set; }
    [Key(1)]
    public short SelectedDefenseDeckIndex { get; set; }
}
