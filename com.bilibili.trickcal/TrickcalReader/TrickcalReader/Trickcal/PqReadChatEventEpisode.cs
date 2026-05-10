using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReadChatEventEpisode {
    [Key(0)]
    public int EventUid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public int EpisodeUid { get; set; }
    [Key(3)]
    public byte[] Branch { get; set; }
}
