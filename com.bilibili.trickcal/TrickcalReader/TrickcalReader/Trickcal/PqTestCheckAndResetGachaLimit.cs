using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestCheckAndResetGachaLimit {
    [Key(0)]
    public int GachaUid { get; set; }
}
