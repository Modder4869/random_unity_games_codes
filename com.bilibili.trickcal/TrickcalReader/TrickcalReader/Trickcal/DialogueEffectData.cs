using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DialogueEffectData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string EffectType { get; set; }
    [Key(2)]
    public int EffectX { get; set; }
    [Key(3)]
    public int EffectY { get; set; }
    [Key(4)]
    public float EffectScale { get; set; }
    [Key(5)]
    public int EffectRotation { get; set; }
    [Key(6)]
    public float EffectTime { get; set; }
    [Key(7)]
    public float EffectDelay { get; set; }
    [Key(8)]
    public bool EffectLoop { get; set; }
    [Key(9)]
    public DialogueEffectResourceType EffectResourceType { get; set; }
}
