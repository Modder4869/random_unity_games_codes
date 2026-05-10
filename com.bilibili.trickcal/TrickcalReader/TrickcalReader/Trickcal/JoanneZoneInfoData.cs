using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class JoanneZoneInfoData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public int BeforeZone { get; set; }
    [Key(3)]
    public int NextZone { get; set; }
    [Key(4)]
    public int UnitGruop { get; set; }
    [Key(5)]
    public string BackGroundImg { get; set; }
    [Key(6)]
    public string Ground { get; set; }
    [Key(7)]
    public float Screen { get; set; }
    [Key(8)]
    public float Width { get; set; }
    [Key(9)]
    public float Top { get; set; }
    [Key(10)]
    public float Bottom { get; set; }
    [Key(11)]
    public int TileX { get; set; }
    [Key(12)]
    public int TileY { get; set; }
    [Key(13)]
    public string BGM { get; set; }
}
