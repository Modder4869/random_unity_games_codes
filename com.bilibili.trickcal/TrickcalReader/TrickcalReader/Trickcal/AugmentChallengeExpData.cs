using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AugmentChallengeExpData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ExpValue { get; set; }
    [Key(2)]
    public string Icon { get; set; }
}
