using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCheckGuildName {
    [Key(0)]
    public string GuildName { get; set; }
}
