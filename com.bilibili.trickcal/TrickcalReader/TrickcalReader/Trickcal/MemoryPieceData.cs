using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MemoryPieceData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int StoryUid { get; set; }
    [Key(2)]
    public int EventUid { get; set; }
    [Key(3)]
    public int Chapter { get; set; }
    [Key(4)]
    public int Episode { get; set; }
    [Key(5)]
    public int Sort { get; set; }
    [Key(6)]
    public MemoryPieceType MemoryPieceType { get; set; }
    [Key(7)]
    public string CG { get; set; }
    [Key(8)]
    public string Name { get; set; }
    [Key(9)]
    public int InteractionUid { get; set; }
    [Key(10)]
    public string BGM { get; set; }
}
