using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSelectWorldTower {
    [Key(0)]
    public int WorldUid { get; set; }
}
