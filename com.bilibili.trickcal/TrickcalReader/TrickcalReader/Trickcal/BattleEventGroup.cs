using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BattleEventGroup {
    [Key(0)]
    public int WaveOrder { get; set; }
    [Key(1)]
    public BattleEventGroupType GroupType { get; set; }
    [Key(2)]
    public List<IBattleEvent> BattleEvents { get; set; }
}
