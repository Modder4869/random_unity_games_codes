using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TestHeroSetGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public int HeroRank { get; set; }
    [Key(3)]
    public int BoardCount { get; set; }
    [Key(4)]
    public bool EquipState { get; set; }
    [Key(5)]
    public short EnhanceLevel { get; set; }
    [Key(6)]
    public int AsideGrade { get; set; }
    [Key(7)]
    public int AsideLevel { get; set; }
    [Key(8)]
    public int ExBoardGroupUid { get; set; }
}
