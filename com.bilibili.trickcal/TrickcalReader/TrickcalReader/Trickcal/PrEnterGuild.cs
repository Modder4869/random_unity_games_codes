using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEnterGuild {
    [Key(0)]
    public IGuildData GuildData { get; set; }
    [Key(1)]
    public List<GuildMemberData> Members { get; set; }
    [Key(2)]
    public bool IsTransferGuildMaster { get; set; }
}
