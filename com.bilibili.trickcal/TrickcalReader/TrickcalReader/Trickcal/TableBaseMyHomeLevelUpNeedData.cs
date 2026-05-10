using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableBaseMyHomeLevelUpNeedData {
    [Key(3)]
    public int HomeLevel { get; set; }
    [Key(4)]
    public int UserLevel { get; set; }
}
