using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameDianaYesterWhiteSpell : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Key { get; set; }
    [Key(2)]
    public int AcquireCondition { get; set; }
    [Key(3)]
    public string Name { get; set; }
    [Key(4)]
    public string Desc { get; set; }
    [Key(5)]
    public string Icon { get; set; }
    [Key(6)]
    public string[] Param { get; set; }
    [Key(7)]
    public int Interaction { get; set; }
    [Key(8)]
    public bool IsActive { get; set; }
}
