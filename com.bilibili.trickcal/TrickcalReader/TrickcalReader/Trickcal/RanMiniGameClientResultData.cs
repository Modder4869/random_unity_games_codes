using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RanMiniGameClientResultData {
    [Key(0)]
    public int Score { get; set; }
    [Key(1)]
    public int PlayTimeMilliSeconds { get; set; }
    [Key(2)]
    public List<RanMiniGameClientResultData.SlideData> SlideDataList { get; set; }
    [Key(3)]
    public int MaxCombo { get; set; }

    [MessagePackObject]
    public class FoodData {
        [Key(0)]
        public int FoodUid { get; set; }
        [Key(1)]
        public int TimingMs { get; set; }
        [Key(2)]
        public bool IsFever { get; set; }
    }

    [MessagePackObject]
    public class SlideData {
        [Key(0)]
        public List<RanMiniGameClientResultData.FoodData> FoodDataList { get; set; }
    }
}
