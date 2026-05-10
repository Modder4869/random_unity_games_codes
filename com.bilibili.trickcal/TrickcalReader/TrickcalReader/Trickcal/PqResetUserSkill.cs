using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqResetUserSkill {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
