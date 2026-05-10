using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GuildMemberData {
    [Key(0)]
    public UserSimpleData UserSimpleData { get; set; }
    [Key(1)]
    public GuildRoleType RoleType { get; set; }
    [Key(2)]
    public int MainHeroId { get; set; }
    [Key(3)]
    public int MainPetId { get; set; }
    [Key(4)]
    public DateTime LastDailyBeginnerSupportTime { get; set; }
    [Key(5)]
    public int DailyBeginnerSupportUserId { get; set; }
    [Key(6)]
    public int MainHeroSkinId { get; set; }
}
