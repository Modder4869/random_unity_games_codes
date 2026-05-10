using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserPetDispatchTaskData {
    [Key(0)]
    public int TimeIndex { get; set; }
    [Key(1)]
    public DateTime StartTime { get; set; }
    [Key(2)]
    public DateTime CompleteTime { get; set; }
    [Key(3)]
    public int[] PetIds { get; set; }
    [Key(4)]
    public int RentUserId { get; set; }
    [Key(5)]
    public int RentPetId { get; set; }
}
