using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCompleteMyHomeProduction {
    [Key(0)]
    public int SlotIndex { get; set; }
    [Key(1)]
    public int MainCategoryId { get; set; }
}
