using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GuildJoinRequestData {
    [Key(0)]
    public UserSimpleData UserSimpleData { get; set; }
    [Key(1)]
    public DateTime RequestTime { get; set; }
}
