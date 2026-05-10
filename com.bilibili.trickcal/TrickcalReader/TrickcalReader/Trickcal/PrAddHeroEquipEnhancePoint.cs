using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrAddHeroEquipEnhancePoint {
    [Key(0)]
    public short GradeUpCount { get; set; }
    [Key(1)]
    public List<Goods> ReturnItems { get; set; }
}
