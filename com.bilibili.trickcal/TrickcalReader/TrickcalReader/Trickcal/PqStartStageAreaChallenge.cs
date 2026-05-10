using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartStageAreaChallenge {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int AreaChallengeUid { get; set; }
    [Key(2)]
    public int StageUid { get; set; }
    [Key(3)]
    public PlayDeckData PlayDeckData { get; set; }
    [Key(4)]
    public bool IsAutoPlay { get; set; }
}
