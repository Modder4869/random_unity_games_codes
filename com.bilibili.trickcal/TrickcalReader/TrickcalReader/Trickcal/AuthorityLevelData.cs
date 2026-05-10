using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AuthorityLevelData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Level { get; set; }
    [Key(2)]
    public float[] Param { get; set; }
    [Key(3)]
    public string[] ParamNew { get; set; }
}
