using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RanEditionMiniGameClientResultData {
    [Key(0)]
    public int ModeUid { get; set; }
    [Key(1)]
    public int Score { get; set; }
    [Key(2)]
    public int PlayTimeMilliSeconds { get; set; }
    [Key(3)]
    public List<RanEditionMiniGameClientResultData.SkillData> SkillDataList { get; set; }
    [Key(4)]
    public List<RanEditionMiniGameClientResultData.SlideData> SlideDataList { get; set; }
    [Key(5)]
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
    public class SkillData {
        [Key(0)]
        public int SkillUid { get; set; }
        [Key(1)]
        public int TimingMs { get; set; }
    }

    [MessagePackObject]
    public class SlideData {
        [Key(0)]
        public List<RanEditionMiniGameClientResultData.FoodData> FoodDataList { get; set; }
    }
}
