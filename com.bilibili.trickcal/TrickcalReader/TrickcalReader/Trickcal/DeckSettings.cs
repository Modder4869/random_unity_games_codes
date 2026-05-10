using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DeckSettings {
    [Key(0)]
    public UserDeckKey DeckKey { get; set; }
    [Key(1)]
    public string Name { get; set; }
    [Key(2)]
    public int[] PositionHeroes { get; set; }
    [Key(3)]
    public short CardDeckIndex { get; set; }
}
