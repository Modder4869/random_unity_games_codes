using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetWWERoundInfo {
    [Key(0)]
    public int SeasonId { get; set; }
}
