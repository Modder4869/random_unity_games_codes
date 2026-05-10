using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HelpData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public HelpType Type { get; set; }
    [Key(2)]
    public HelpCategoryType Category { get; set; }
    [Key(3)]
    public int Order { get; set; }
    [Key(4)]
    public HelpUnlockType UnlockType { get; set; }
    [Key(5)]
    public int UnlockValue { get; set; }
    [Key(6)]
    public string HelpTitle { get; set; }
    [Key(7)]
    public string HelpName { get; set; }
    [Key(8)]
    public int HelpPage { get; set; }
    [Key(9)]
    public bool IsReward { get; set; }
}
