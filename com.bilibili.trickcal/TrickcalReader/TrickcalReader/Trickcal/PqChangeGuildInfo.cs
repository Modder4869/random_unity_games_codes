using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqChangeGuildInfo {
    [Key(0)]
    public GuildSettingData SettingData { get; set; }
}
