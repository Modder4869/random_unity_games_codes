using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RanMiniGameSaveData {
    [Key(0)]
    public List<RanMiniGameSaveData.RankData> RankDataList { get; set; }
    [Key(1)]
    public int[] Endings { get; set; }

    [MessagePackObject]
    public class RankData {
        [Key(0)]
        public int Score { get; set; }
        [Key(1)]
        public int PlayTimeMilliSeconds { get; set; }
        [Key(2)]
        public DateTime PlayDateTime { get; set; }
        [Key(3)]
        public int MaxCombo { get; set; }
    }
}
