using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserChatEventEpisodeData {
    [Key(0)]
    public bool IsRead { get; set; }
    [Key(1)]
    public bool IsRewardReceived { get; set; }
    [Key(2)]
    public byte[] SelectedBranch { get; set; }
}
