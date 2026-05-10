using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameTopRankUserData {
    [Key(0)]
    public int ProfileIcon { get; set; }
    [Key(1)]
    public int ProfileBoader { get; set; }
}
