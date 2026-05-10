using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAttachHeroEquip {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public short[] EquipSlotIndexes { get; set; }
    [Key(2)]
    public bool IsUseEquipPart { get; set; }
}
