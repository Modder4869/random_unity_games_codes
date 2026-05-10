using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSendTowerBattleEmotion {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public int EmotionId { get; set; }
}
