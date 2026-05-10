using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserGuildData {
    [Key(0)]
    public int GuildId { get; set; }
    [Key(1)]
    public DateTime LastAttendanceTime { get; set; }
    [Key(2)]
    public DateTime LastJoinTime { get; set; }
    [Key(3)]
    public DateTime LastLeaveTime { get; set; }
    [Key(4)]
    public DateTime LastRentTime { get; set; }
    [Key(5)]
    public int[] RentUserIds { get; set; }
    [Key(6)]
    public int PetInteractionRewardCount { get; set; }
    [Key(7)]
    public DateTime LastPetInteractionRewardTime { get; set; }
    [Key(8)]
    public int RentRewardReceiveStackedCount { get; set; }
    [Key(9)]
    public short DailyBeginnerSupportSendCount { get; set; }
    [Key(10)]
    public int PetRentRewardReceiveStackedCount { get; set; }
    [Key(11)]
    public DateTime LastPetRentTime { get; set; }
}
