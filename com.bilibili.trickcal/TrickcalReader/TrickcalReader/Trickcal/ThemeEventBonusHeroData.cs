using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ThemeEventBonusHeroData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public int BonusRate { get; set; }
}
