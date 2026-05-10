using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqResetHeroBoards {
    [Key(0)]
    public int HeroId { get; set; }
}
