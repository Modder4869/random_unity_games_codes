using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetInitializeUserCount {
    [Key(0)]
    public InitializeType[] InitializeType { get; set; }
}
