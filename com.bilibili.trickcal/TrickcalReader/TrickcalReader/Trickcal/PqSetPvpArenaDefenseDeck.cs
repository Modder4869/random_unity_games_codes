using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetPvpArenaDefenseDeck {
    [Key(0)]
    public int[] DefenseHeroesPresets { get; set; }
    [Key(1)]
    public int[] DefenseHeroHiddenBitsPresets { get; set; }
    [Key(2)]
    public int[] DefenseHeroes { get; set; }
    [Key(3)]
    public int DefenseHeroHiddenBits { get; set; }
    [Key(4)]
    public string[] DefenseDeckNamePresets { get; set; }
    [Key(5)]
    public string DefenseDeckName { get; set; }
}
