using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableBaseItemData {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int LimitNum { get; set; }
    [Key(2)]
    public string Name { get; set; }
    [Key(3)]
    public string Desc { get; set; }
    [Key(4)]
    public string Icon { get; set; }
    [Key(5)]
    public int SaleReplaceItemValue { get; set; }
    [Key(6)]
    public int Rarity { get; set; }
    [Key(7)]
    public ItemNavigationType[] NavigationTypes { get; set; }
    [Key(8)]
    public string Spine { get; set; }
    [Key(9)]
    public string Resource { get; set; }
    [Key(10)]
    public int MailLimitNum { get; set; }
    [Key(11)]
    public DateTime? ExpireTime { get; set; }
    [Key(12)]
    public int SaleReplaceItemUid { get; set; }
    [Key(13)]
    public ItemVisibleType ItemVisibleType { get; set; }
}
