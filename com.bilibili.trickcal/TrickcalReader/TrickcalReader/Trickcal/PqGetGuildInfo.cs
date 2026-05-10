using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetGuildInfo {
    [Key(0)]
    public int GuildId { get; set; }
}
