using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDismissContentUnlock {
    [Key(0)]
    public ContentsType[] ContentsTypes { get; set; }
}
