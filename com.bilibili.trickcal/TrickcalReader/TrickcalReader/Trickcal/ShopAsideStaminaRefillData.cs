using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopAsideStaminaRefillData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int RefillCount { get; set; }
    [Key(2)]
    public int AnyCashPrice { get; set; }
    [Key(3)]
    public int StaminaValue { get; set; }
}
