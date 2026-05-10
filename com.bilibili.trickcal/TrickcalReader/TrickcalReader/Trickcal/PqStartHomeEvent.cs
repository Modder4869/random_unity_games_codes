using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartHomeEvent {
    [Key(0)]
    public int HomeEventInfoUid { get; set; }
}
