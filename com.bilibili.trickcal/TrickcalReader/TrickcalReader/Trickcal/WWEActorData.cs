using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEActorData {
    [Key(1)]
    public string ActorGUID { get; set; }
}
