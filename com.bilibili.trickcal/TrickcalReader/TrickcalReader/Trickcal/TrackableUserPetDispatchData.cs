using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserPetDispatchData {
    [Key(0)]
    public int PetDispatchLevel { get; set; }
    [Key(1)]
    public int RentGuildPetCount { get; set; }
    [Key(2)]
    public int[] RentGuildUserIds { get; set; }
}
