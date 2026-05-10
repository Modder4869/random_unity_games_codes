using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrTrainingRoomEnterLobby {
    [Key(0)]
    public int? LastPlayedStageUid { get; set; }
}
