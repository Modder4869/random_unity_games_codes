using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqResetChatEventEpisodeRead {
    [Key(0)]
    public int EventUid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public int EpisodeUid { get; set; }
}
