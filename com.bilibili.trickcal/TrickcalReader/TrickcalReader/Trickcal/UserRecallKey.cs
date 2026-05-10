using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserRecallKey {
    [Key(0)]
    public int RecallOperationId { get; set; }
    [Key(1)]
    public int HeroId { get; set; }
}
