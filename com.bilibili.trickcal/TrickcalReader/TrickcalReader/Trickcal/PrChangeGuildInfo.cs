using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrChangeGuildInfo {
    [Key(0)]
    public IGuildData GuildData { get; set; }
}
