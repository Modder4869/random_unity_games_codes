using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LobbyEffectData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string[] EffectName { get; set; }
    [Key(2)]
    public float[] EffectX { get; set; }
    [Key(3)]
    public float[] EffectY { get; set; }
    [Key(4)]
    public float[] EffectZ { get; set; }
}
