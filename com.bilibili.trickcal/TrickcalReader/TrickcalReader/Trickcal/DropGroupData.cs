using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DropGroupData {
    [Key(0)]
    public DropGroupType Type { get; set; }
    [Key(1)]
    public int DropGroupId { get; set; }
    [Key(2)]
    public List<TableBaseDropData> Drops { get; set; }
    [Key(3)]
    public int SumWeights { get; set; }
    [Key(4)]
    public bool HasUniqueDrop { get; set; }
    [Key(5)]
    public TableBaseDropData FallbackDrop { get; set; }
}
