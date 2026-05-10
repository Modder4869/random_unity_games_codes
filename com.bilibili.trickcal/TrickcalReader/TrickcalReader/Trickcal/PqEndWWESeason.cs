using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndWWESeason {
    [Key(0)]
    public int SeasonId { get; set; }
}
