using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqJoinGuild {
    [Key(0)]
    public int GuildId { get; set; }
}
