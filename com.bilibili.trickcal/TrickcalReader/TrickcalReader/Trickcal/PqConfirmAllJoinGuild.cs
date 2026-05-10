using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqConfirmAllJoinGuild {
    [Key(0)]
    public bool IsAccept { get; set; }
}
