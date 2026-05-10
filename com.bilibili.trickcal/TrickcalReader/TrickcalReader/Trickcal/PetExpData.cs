using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetExpData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int[] NeedExps { get; set; }
    [Key(2)]
    public int[] NeedGold { get; set; }
}
