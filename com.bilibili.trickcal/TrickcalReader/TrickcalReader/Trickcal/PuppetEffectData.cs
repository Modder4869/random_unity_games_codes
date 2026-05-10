using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PuppetEffectData : TableItem<TableData> {
    [Key(0)]
    public int EpisodeUid { get; set; }
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public PuppetEffectTriggerType TriggerType { get; set; }
    [Key(3)]
    public string TriggerValue { get; set; }
    [Key(4)]
    public string PrefabName { get; set; }
    [Key(5)]
    public string BoneName { get; set; }
    [Key(6)]
    public string SlotName { get; set; }
    [Key(7)]
    public float Scale { get; set; }
    [Key(8)]
    public float Rotation { get; set; }
}
