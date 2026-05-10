using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RecallOptionData {
    [Key(0)]
    public bool IsChecked { get; set; }
    [Key(1)]
    public RecallType RecallType { get; set; }
    [Key(2)]
    public int ItemPercentage { get; set; }
    [Key(3)]
    public int GoldPercentage { get; set; }
    [Key(4)]
    public bool IsExchangeIdCard { get; set; }
}
