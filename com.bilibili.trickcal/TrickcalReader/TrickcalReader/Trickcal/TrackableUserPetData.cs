using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserPetData {
    [Key(0)]
    public short Level { get; set; }
    [Key(1)]
    public int Exp { get; set; }
    [Key(2)]
    public short Flags { get; set; }
    [Key(3)]
    public DateTime OwnTime { get; set; }
}
