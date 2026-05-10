using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SettingCardData {
    [Key(0)]
    public int CardUid { get; set; }
    [Key(1)]
    public int CardLevel { get; set; }
    [Key(2)]
    public int SelectCount { get; set; }
}
