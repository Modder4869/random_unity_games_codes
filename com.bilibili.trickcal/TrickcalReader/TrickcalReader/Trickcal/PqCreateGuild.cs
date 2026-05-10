using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCreateGuild {
    [Key(0)]
    public GuildSettingData SettingData { get; set; }
    [Key(1)]
    public string GuildName { get; set; }
    [Key(2)]
    public int MainHeroId { get; set; }
    [Key(3)]
    public int MainPetId { get; set; }
}
