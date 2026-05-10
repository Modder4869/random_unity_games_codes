using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSearchGuild {
    [Key(0)]
    public string GuildName { get; set; }
}
