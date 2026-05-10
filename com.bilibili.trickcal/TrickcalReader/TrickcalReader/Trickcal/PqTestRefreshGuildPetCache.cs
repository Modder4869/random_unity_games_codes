using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestRefreshGuildPetCache {
    [Key(0)]
    public int GuildId { get; set; }
}
