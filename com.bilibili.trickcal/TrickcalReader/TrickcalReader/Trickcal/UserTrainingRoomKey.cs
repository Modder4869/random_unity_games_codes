using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserTrainingRoomKey {
    [Key(0)]
    public int TrainingRoomId { get; set; }
    [Key(1)]
    public int Index { get; set; }
}
