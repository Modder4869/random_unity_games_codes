using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalSkillLevelData : TableItem<TableData> {
    [Key(0)]
    public string Uid { get; set; }
    [Key(1)]
    public int Level { get; set; }
    [Key(2)]
    public string[] Params { get; set; }
}
