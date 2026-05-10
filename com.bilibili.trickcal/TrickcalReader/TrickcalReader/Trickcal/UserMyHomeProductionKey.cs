using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserMyHomeProductionKey {
    [Key(0)]
    public int MainCategoryUid { get; set; }
    [Key(1)]
    public int SlotUid { get; set; }
}
