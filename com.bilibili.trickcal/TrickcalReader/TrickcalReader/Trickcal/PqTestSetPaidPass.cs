using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetPaidPass {
    [Key(0)]
    public int PassUid { get; set; }
    [Key(1)]
    public bool IsPremium { get; set; }
}
