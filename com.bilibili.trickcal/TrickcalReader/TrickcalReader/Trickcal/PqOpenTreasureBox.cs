using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqOpenTreasureBox {
    [Key(0)]
    public int TreasureBoxUid { get; set; }
    [Key(1)]
    public int OpenCount { get; set; }
    [Key(2)]
    public List<int> SelectDropUidList { get; set; }
    [Key(3)]
    public List<int> SelectRewardUidList { get; set; }
}
