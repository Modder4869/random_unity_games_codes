using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageWaveCardDrawInfo {
    [Key(0)]
    public DrawCardType[] Types { get; set; }
    [Key(1)]
    public int[] Uids { get; set; }
    [Key(2)]
    public int[] Prices { get; set; }
    [Key(3)]
    public short SelectIndex { get; set; }
    [Key(4)]
    public int TargetId { get; set; }
    [Key(5)]
    public bool IsColorfulSuccess { get; set; }
}
