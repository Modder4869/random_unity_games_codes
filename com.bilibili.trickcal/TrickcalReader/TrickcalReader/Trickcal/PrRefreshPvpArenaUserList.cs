using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrRefreshPvpArenaUserList {
    [Key(0)]
    public List<PvpArenaUserData> TargetUsers { get; set; }
}
