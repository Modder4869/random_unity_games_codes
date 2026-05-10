using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroUpgradeData : TableItem<TableData> {
    [Key(0)]
    public short Grade { get; set; }
    [Key(1)]
    public int NeedGold { get; set; }
    [Key(2)]
    public int NeedIdCard { get; set; }
}
