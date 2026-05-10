using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndCookingTycoonMiniGame {
    [Key(0)]
    public int CookingTycoonSeason { get; set; }
    [Key(1)]
    public int StagePlayKey { get; set; }
    [Key(2)]
    public int Score { get; set; }
    [Key(3)]
    public float Duration { get; set; }
    [Key(4)]
    public CookingTycoonValidateData[] ValidateData { get; set; }
    [Key(5)]
    public int CookingTycoonStageUid { get; set; }
    [Key(6)]
    public int PauseCount { get; set; }
    [Key(7)]
    public int LostAppFocusCount { get; set; }
}
