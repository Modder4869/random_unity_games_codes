using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageWaveEffectInfo {
    [Key(0)]
    public StageWaveEffectType StageWaveEffectType { get; set; }
    [Key(1)]
    public int Id { get; set; }
    [Key(2)]
    public long Damage { get; set; }
    [Key(3)]
    public long Heal { get; set; }
}
