using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopEventGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int[] ShopMainCategoryUids { get; set; }
    [Key(2)]
    public string[] ShopBackgrounds { get; set; }
}
