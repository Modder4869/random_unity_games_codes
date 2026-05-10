using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnTowerBattleEmotionAsync {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public int EmotionId { get; set; }
}
