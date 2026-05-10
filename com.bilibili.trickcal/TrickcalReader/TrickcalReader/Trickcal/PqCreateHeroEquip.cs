using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCreateHeroEquip {
    [Key(0)]
    public int EquipId { get; set; }
}
