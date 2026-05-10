using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableGuildData {
    [Key(0)]
    public string Name { get; set; }
    [Key(1)]
    public int EmblemLayer0 { get; set; }
    [Key(2)]
    public int EmblemLayer1 { get; set; }
    [Key(3)]
    public GuildJoinType JoinType { get; set; }
    [Key(4)]
    public GuildActivityType ActivityType { get; set; }
    [Key(5)]
    public short LevelLimit { get; set; }
    [Key(6)]
    public DateTime CreateTime { get; set; }
    [Key(7)]
    public GuildFlags Flags { get; set; }
    [Key(8)]
    public DateTime LastDailyRefreshTime { get; set; }
    [Key(9)]
    public short MemberCount { get; set; }
    [Key(10)]
    public string Notice { get; set; }
    [Key(11)]
    public int MasterUserId { get; set; }
    [Key(12)]
    public DateTime NameChangeTime { get; set; }
    [Key(13)]
    public DateTime MasterLastLoginTime { get; set; }
    [Key(14)]
    public string MasterUserName { get; set; }
    [Key(15)]
    public int MasterUserNameplateId { get; set; }
    [Key(16)]
    public int MasterUserNameStyleId { get; set; }
}
