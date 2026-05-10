using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserHomeEventKey {
    [Key(0)]
    public int HomeEventInfoUid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
}
