using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserChatEventEpisodeKey {
    [Key(0)]
    public int EventUid { get; set; }
    [Key(1)]
    public int ChatEventGroupUid { get; set; }
    [Key(2)]
    public int EpisodeUid { get; set; }
}
