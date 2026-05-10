using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class JoanneUnitGroupData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int UnitUid { get; set; }
    [Key(2)]
    public int TargetUid { get; set; }
    [Key(3)]
    public JoanneUnitGrade Grade { get; set; }
    [Key(4)]
    public PersonalityType Personality { get; set; }
    [Key(5)]
    public TribeType Tribe { get; set; }
    [Key(6)]
    public int Value { get; set; }
    [Key(7)]
    public bool Regen { get; set; }
    [Key(8)]
    public int SpawnTileX { get; set; }
    [Key(9)]
    public int SpawnTileY { get; set; }
}
