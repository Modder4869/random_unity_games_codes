using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeConditionDropGroupData {
    [Key(0)]
    public List<LifeConditionDropData> ConditionDrops { get; set; }
}
