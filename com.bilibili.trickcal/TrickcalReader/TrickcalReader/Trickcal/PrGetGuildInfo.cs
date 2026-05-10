using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetGuildInfo {
    [Key(0)]
    public IGuildData GuildData { get; set; }
    [Key(1)]
    public List<GuildMemberData> Members { get; set; }
}
