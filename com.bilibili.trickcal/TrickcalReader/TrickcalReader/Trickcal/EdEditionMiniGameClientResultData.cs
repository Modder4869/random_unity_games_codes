using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EdEditionMiniGameClientResultData {
    [Key(0)]
    public Dictionary<int, Dictionary<int, int>> HeroGradeCountMap { get; set; }
    [Key(1)]
    public int TotalPlayTimeMs { get; set; }
    [Key(2)]
    public int TotalPauseTimeMs { get; set; }
    [Key(3)]
    public Dictionary<int, Dictionary<int, int>> ActiveSkillUseCountMap { get; set; }
    [Key(4)]
    public int WaveClearCount { get; set; }
    [Key(5)]
    public List<EdEditionMiniGameClientResultData.WaveData> WaveDataList { get; set; }
    [Key(6)]
    public List<EdEditionMiniGameClientResultData.GachaData> GachaDataList { get; set; }
    [Key(7)]
    public List<EdEditionMiniGameClientResultData.AcademyUpgradeData> AcademyUpgradeDataList { get; set; }
    [Key(8)]
    public int SelectedActiveSkillUid { get; set; }
    [Key(9)]
    public List<EdEditionMiniGameClientResultData.ActiveSkillUseData> ActiveSkillUseDataList { get; set; }
    [Key(10)]
    public List<EdEditionMiniGameClientResultData.TowerMergeData> TowerMergeDataList { get; set; }
    [Key(11)]
    public List<EdEditionMiniGameClientResultData.TowerSellData> TowerSellDataList { get; set; }

    [MessagePackObject]
    public class WaveData {
        [Key(0)]
        public int Wave { get; set; }
        [Key(1)]
        public int StartTimeMs { get; set; }
        [Key(2)]
        public int EndTimeMs { get; set; }
        [Key(3)]
        public bool IsClear { get; set; }
        [Key(4)]
        public int Money { get; set; }
        [Key(5)]
        public List<EdEditionMiniGameClientResultData.TowerData> TowerDataList { get; set; }
        [Key(6)]
        public List<EdEditionMiniGameClientResultData.AcademyData> AcademyDataList { get; set; }
    }

    [MessagePackObject]
    public class GachaData {
        [Key(0)]
        public int Wave { get; set; }
        [Key(1)]
        public int TimeMs { get; set; }
        [Key(2)]
        public int OldMoney { get; set; }
        [Key(3)]
        public int NewMoney { get; set; }
        [Key(4)]
        public int TowerUid { get; set; }
        [Key(5)]
        public int UnitUid { get; set; }
        [Key(6)]
        public int UnitGrade { get; set; }
    }

    [MessagePackObject]
    public class AcademyUpgradeData {
        [Key(0)]
        public int Wave { get; set; }
        [Key(1)]
        public int TimeMs { get; set; }
        [Key(2)]
        public int OldMoney { get; set; }
        [Key(3)]
        public int NewMoney { get; set; }
        [Key(4)]
        public int TowerUid { get; set; }
        [Key(5)]
        public int UnitUid { get; set; }
        [Key(6)]
        public int UpgradeValue { get; set; }
    }

    [MessagePackObject]
    public class TowerData {
        [Key(0)]
        public int TowerUid { get; set; }
        [Key(1)]
        public int UnitUid { get; set; }
        [Key(2)]
        public int UnitGrade { get; set; }
    }

    [MessagePackObject]
    public class TowerMergeData {
        [Key(0)]
        public int Wave { get; set; }
        [Key(1)]
        public int TimeMs { get; set; }
        [Key(2)]
        public EdEditionMiniGameClientResultData.TowerData TowerData { get; set; }
        [Key(3)]
        public EdEditionMiniGameClientResultData.TowerData[] NeedTowerDataArray { get; set; }
    }

    [MessagePackObject]
    public class TowerSellData {
        [Key(0)]
        public int Wave { get; set; }
        [Key(1)]
        public int TimeMs { get; set; }
        [Key(2)]
        public int OldMoney { get; set; }
        [Key(3)]
        public int NewMoney { get; set; }
        [Key(4)]
        public EdEditionMiniGameClientResultData.TowerData TowerData { get; set; }
    }

    [MessagePackObject]
    public class AcademyData {
        [Key(0)]
        public int UnitUid { get; set; }
        [Key(1)]
        public int UpgradeValue { get; set; }
    }

    [MessagePackObject]
    public class ActiveSkillUseData {
        [Key(0)]
        public int Wave { get; set; }
        [Key(1)]
        public int TimeMs { get; set; }
        [Key(2)]
        public int ActiveSkillUid { get; set; }
    }
}
