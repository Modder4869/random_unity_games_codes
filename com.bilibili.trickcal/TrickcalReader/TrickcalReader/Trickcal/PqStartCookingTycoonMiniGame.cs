using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartCookingTycoonMiniGame {
    [Key(0)]
    public int CookingTycoonSeason { get; set; }
    [Key(1)]
    public int CookingTycoonStageUid { get; set; }
}
