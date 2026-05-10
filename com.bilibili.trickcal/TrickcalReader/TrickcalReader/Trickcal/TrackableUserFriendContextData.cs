using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserFriendContextData {
    [Key(0)]
    public short SendSocialPointCount { get; set; }
    [Key(1)]
    public short ReceiveSocialPointCount { get; set; }
    [Key(2)]
    public bool IsSendDailySocialPoint { get; set; }
    [Key(3)]
    public short SocialEventPointCount { get; set; }
    [Key(4)]
    public DateTime SocialEventTime { get; set; }
    [Key(5)]
    public int[] HelpFriendList { get; set; }
}
