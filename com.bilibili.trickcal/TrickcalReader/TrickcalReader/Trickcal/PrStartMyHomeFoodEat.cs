using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrStartMyHomeFoodEat {
    [Key(0)]
    public int EpisodeId { get; set; }
    [Key(1)]
    public bool IsFirstEatFood { get; set; }
}
