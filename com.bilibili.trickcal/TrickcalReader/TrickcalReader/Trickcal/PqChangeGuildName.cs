using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqChangeGuildName {
    [Key(0)]
    public string GuildName { get; set; }
}
