using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetDispatchLevelUpData : TableItem<TableData> {
    [Key(0)]
    public int Level { get; set; }
    [Key(1)]
    public int NeedGold { get; set; }
    [Key(2)]
    public int[] NeedItem { get; set; }
    [Key(3)]
    public int[] NeedValue { get; set; }
    [Key(4)]
    public int DispatchPartyMaxValue { get; set; }
}
