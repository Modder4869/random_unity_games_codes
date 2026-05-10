using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveUserLvPassReward {
    [Key(0)]
    public int UserLvPassGroupUid { get; set; }
    [Key(1)]
    public int Level { get; set; }
    [Key(2)]
    public bool IsPaid { get; set; }
}
