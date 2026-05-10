using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableBaseMyHomeLevelUpNeedItemData {
    [Key(0)]
    public int Gold { get; set; }
    [Key(1)]
    public int[] ItemArray { get; set; }
    [Key(2)]
    public int[] ValueArray { get; set; }
}
