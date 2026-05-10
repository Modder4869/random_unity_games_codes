using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ButterMiniGameClientResultData {
    [Key(0)]
    public int BeatMapGroupUid { get; set; }
    [Key(1)]
    public ButterMiniGameDifficultyType BeatMapDifficultyType { get; set; }
    [Key(2)]
    public List<ButterMiniGameClientResultData.NoteData> NoteDataList { get; set; }
    [Key(3)]
    public int Score { get; set; }
    [Key(4)]
    public int Hp { get; set; }

    [MessagePackObject]
    public class NoteData {
        [Key(0)]
        public int NoteIndex { get; set; }
        [Key(1)]
        public int TimingMs { get; set; }
        [Key(2)]
        public bool IsFever { get; set; }
        [Key(3)]
        public int Combo { get; set; }
        [Key(4)]
        public bool IsMissed { get; set; }
    }
}
