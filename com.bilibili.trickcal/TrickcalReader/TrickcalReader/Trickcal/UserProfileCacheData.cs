using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserProfileCacheData {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public string Nickname { get; set; }
    [Key(2)]
    public int UserLevel { get; set; }
    [Key(3)]
    public int Icon { get; set; }
    [Key(4)]
    public int Border { get; set; }
    [Key(5)]
    public int GuildId { get; set; }
    [Key(6)]
    public string GuildName { get; set; }
    [Key(7)]
    public int Nameplate { get; set; }
    [Key(8)]
    public int NameStyle { get; set; }
}
