using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndTrainingRoom {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public IStageGameResult GameResult { get; set; }
}
