using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWESpellData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int SpellUid { get; set; }
    [Key(2)]
    public TeamType Team { get; set; }
    [Key(3)]
    public int Level { get; set; }
    [Key(4)]
    public int Count { get; set; }
}
