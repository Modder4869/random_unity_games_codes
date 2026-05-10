using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetLevelData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Level { get; set; }
    [Key(2)]
    public float[] StatParam { get; set; }
    [Key(3)]
    public int[] EffectParam { get; set; }
    [Key(4)]
    public float[] Param { get; set; }
}
