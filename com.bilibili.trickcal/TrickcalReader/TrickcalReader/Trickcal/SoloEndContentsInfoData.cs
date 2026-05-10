using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloEndContentsInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int WorldGroupUid { get; set; }
    [Key(2)]
    public int AuthorityGroup { get; set; }
    [Key(3)]
    public bool IsDeleted { get; set; }
    [Key(4)]
    public int BossLevelGroup { get; set; }
    [Key(5)]
    public int ShopMainCategoryUid { get; set; }
    [Key(6)]
    public GroupType GroupType { get; set; }
    [Key(7)]
    public int SoloEndId { get; set; }
    [Key(8)]
    public SoloEndTableKey SoloEndTableKey { get; set; }
}
