using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserFriendData {
    [Key(0)]
    public DateTime CreateTime { get; set; }
    [Key(1)]
    public DateTime LastPointSendTime { get; set; }
    [Key(2)]
    public DateTime LastPointReceiveTime { get; set; }
    [Key(3)]
    public bool IsPointReceived { get; set; }
    [Key(4)]
    public short HelpCount { get; set; }
    [Key(5)]
    public short SocialEventHelpCount { get; set; }
}
