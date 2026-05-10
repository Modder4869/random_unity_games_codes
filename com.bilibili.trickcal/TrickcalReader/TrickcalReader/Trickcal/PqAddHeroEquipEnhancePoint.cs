using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAddHeroEquipEnhancePoint {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public short EquipSlotIndex { get; set; }
    [Key(2)]
    public Goods[] MaterialItems { get; set; }
}
