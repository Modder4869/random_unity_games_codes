using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetUserComment {
    [Key(0)]
    public string UserComment { get; set; }
}
