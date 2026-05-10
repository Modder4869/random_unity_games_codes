using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetWWERecord {
    [Key(0)]
    public byte[] RecordData { get; set; }
    [Key(1)]
    public List<Goods> Rewards { get; set; }
    [Key(2)]
    public string MatchResultUrl { get; set; }
}
