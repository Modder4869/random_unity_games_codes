using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqConfirmJoinGuild {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public bool IsAccept { get; set; }
}
