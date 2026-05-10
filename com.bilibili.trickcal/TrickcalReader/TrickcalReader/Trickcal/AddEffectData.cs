using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AddEffectData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ArtifactEffectType EffectType { get; set; }
    [Key(2)]
    public bool OverlapCheck { get; set; }
}
