using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetChaosArenaDefenseCard {
    [Key(0)]
    public int ChaosArenaSeasonId { get; set; }
    [Key(1)]
    public int[] SelectedCardUids { get; set; }
}
