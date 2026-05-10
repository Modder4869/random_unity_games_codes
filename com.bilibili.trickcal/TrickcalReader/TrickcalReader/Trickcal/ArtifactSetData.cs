using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ArtifactSetData : TableItem<TableData> {
    [Key(0)]
    public int ArtifactGroup { get; set; }
    [Key(1)]
    public string ArtifactAction { get; set; }
    [Key(2)]
    public ArtifactTriggerType TriggerType { get; set; }
    [Key(3)]
    public string UseIconEffect { get; set; }
}
