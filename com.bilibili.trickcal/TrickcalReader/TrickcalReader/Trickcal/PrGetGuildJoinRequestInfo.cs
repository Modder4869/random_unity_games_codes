using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetGuildJoinRequestInfo {
    [Key(0)]
    public List<GuildJoinRequestData> JoinRequests { get; set; }
}
