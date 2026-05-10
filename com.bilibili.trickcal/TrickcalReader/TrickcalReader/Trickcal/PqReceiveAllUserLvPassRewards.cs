using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAllUserLvPassRewards {
    [Key(0)]
    public int UserLvPassGroupUid { get; set; }
}
