using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopMainCategoryData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ShopType Type { get; set; }
    [Key(2)]
    public string MainTab { get; set; }
    [Key(3)]
    public int MainTabSort { get; set; }
    [Key(4)]
    public int InteractionUid { get; set; }
    [Key(5)]
    public string TabIcon { get; set; }
    [Key(6)]
    public string BgImagePath { get; set; }
}
