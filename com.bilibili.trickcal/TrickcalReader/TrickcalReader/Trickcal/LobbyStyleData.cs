using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LobbyStyleData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Theme { get; set; }
    [Key(2)]
    public LobbyAside LobbyAside { get; set; }
    [Key(3)]
    public bool IsSpine { get; set; }
    [Key(4)]
    public float[] LookDirection { get; set; }
    [Key(5)]
    public float[] CharacterX { get; set; }
    [Key(6)]
    public float[] CharacterY { get; set; }
    [Key(7)]
    public float[] CharacterZ { get; set; }
    [Key(8)]
    public float[] CharacterScale { get; set; }
    [Key(9)]
    public string Background { get; set; }
    [Key(10)]
    public string[] Structure { get; set; }
    [Key(11)]
    public float[] StructureX { get; set; }
    [Key(12)]
    public float[] StructureY { get; set; }
    [Key(13)]
    public float[] StructureZ { get; set; }
    [Key(14)]
    public float[] AsideX { get; set; }
    [Key(15)]
    public float[] AsideY { get; set; }
    [Key(16)]
    public float[] AsideZ { get; set; }
    [Key(17)]
    public float[] StructureScale { get; set; }
}
