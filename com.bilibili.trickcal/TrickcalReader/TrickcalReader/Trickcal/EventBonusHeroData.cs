using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventBonusHeroData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int WorldUid { get; set; }
    [Key(2)]
    public int HeroUid { get; set; }
    [Key(3)]
    public int BonusRate { get; set; }
}
