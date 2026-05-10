using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrPrepareConfirmAllJoinGuild {
    [Key(1)]
    public int[] UserIds { get; set; }
}
