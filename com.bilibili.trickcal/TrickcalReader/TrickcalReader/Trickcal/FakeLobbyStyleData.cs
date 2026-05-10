using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class FakeLobbyStyleData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int MaxInterActionNum { get; set; }
    [Key(2)]
    public float[] MaxCharacterX { get; set; }
    [Key(3)]
    public float[] MaxCharacterY { get; set; }
    [Key(4)]
    public float[] MaxCharacterZ { get; set; }
    [Key(5)]
    public float[] MaxCharacterScale { get; set; }
    [Key(6)]
    public float[] MinCharacterX { get; set; }
    [Key(7)]
    public float[] MinCharacterY { get; set; }
    [Key(8)]
    public float[] MinCharacterZ { get; set; }
    [Key(9)]
    public float MinCharacterScale { get; set; }
    [Key(10)]
    public string ExplosionEffect { get; set; }
    [Key(11)]
    public string ExplosionSound { get; set; }
}
