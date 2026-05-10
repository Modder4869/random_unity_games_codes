using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AsideUpgradeData : TableItem<TableData> {
    [Key(0)]
    public int Grade { get; set; }
    [Key(1)]
    public int NeedGold { get; set; }
    [Key(2)]
    public int SumGold { get; set; }
    [Key(3)]
    public int NeedIdCard { get; set; }
    [Key(4)]
    public int SumIdCard { get; set; }
    [Key(5)]
    public int LimitLevel { get; set; }
    [Key(6)]
    public int UnlockSkillLevel { get; set; }
}
