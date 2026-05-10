using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BoostOptionData {
    [Key(0)]
    public int StartLevel { get; set; }
    [Key(1)]
    public int EndLevel { get; set; }
    [Key(2)]
    public int BoostPercent { get; set; }
}
