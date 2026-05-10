using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserLevelUpData : TableItem<TableData> {
    [Key(0)]
    public int UserLevel { get; set; }
    [Key(1)]
    public int NeedExp { get; set; }
    [Key(2)]
    public int MaxStamina { get; set; }
}
