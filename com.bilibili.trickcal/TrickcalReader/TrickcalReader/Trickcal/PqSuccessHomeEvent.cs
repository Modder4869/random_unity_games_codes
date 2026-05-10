using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSuccessHomeEvent {
    [Key(0)]
    public int HomeEventInfoUid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
}
