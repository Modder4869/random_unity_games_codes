using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEUnitInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int UnitUid { get; set; }
    [Key(2)]
    public int SkinUid { get; set; }
    [Key(3)]
    public TeamType Team { get; set; }
    [Key(4)]
    public int Position { get; set; }
    [Key(5)]
    public int Grow { get; set; }
    [Key(6)]
    public string Grade { get; set; }
    [Key(7)]
    public string Level { get; set; }
    [Key(8)]
    public string SPSkill { get; set; }
    [Key(9)]
    public string Ultimate { get; set; }
    [Key(10)]
    public string Equip { get; set; }
    [Key(11)]
    public short[] EquipEnhance { get; set; }
    [Key(12)]
    public string AsideGrade { get; set; }
    [Key(13)]
    public string AsideExp { get; set; }
    [Key(14)]
    public int[] ArtifactParams { get; set; }
    [Key(15)]
    public int[] ArtifactLevels { get; set; }
}
