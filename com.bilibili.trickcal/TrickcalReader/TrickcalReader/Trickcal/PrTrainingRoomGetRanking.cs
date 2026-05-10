using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrTrainingRoomGetRanking {
    [Key(0)]
    public IUserTrainingRoomData BestScore { get; set; }
    [Key(1)]
    public IUserTrainingRoomData[] Others { get; set; }
}
