using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GuildHeroRentData {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public string UserName { get; set; }
    [Key(2)]
    public StatHeroData StatHeroData { get; set; }
}
