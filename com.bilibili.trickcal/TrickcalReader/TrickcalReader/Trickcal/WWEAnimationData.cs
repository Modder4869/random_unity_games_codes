using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEAnimationData {
    [Key(2)]
    public string Animation { get; set; }
    [Key(3)]
    public bool IsLoop { get; set; }
}
