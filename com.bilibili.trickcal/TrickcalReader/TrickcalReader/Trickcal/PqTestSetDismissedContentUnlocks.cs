using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetDismissedContentUnlocks {
    [Key(0)]
    public ContentsType[] ContentsTypes { get; set; }
    [Key(1)]
    public bool IsAdd { get; set; }
}
